using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BackupRestore
{
    public partial class FormMain : Form
    {
        public static Database curentDB;

        public FormMain()
        {
            InitializeComponent();
            dtp_DateRestore.CustomFormat = "dd-MM-yyyy";
            dtp_TimeRestore.CustomFormat = "HH:mm:ss";

            Thread thread = new Thread(new ThreadStart(() =>
            {
                TimerAction.AddTimer((args, e) => { InvokeUI(() => { this.lbl_Time.Text = DateTime.Now.ToLongTimeString(); }); }, 1000);
            }));
            thread.Start();

            showDBList();
            setListBK();
        }

        public void showDBList()
        {
            List<Database> list = getListDB();
            foreach (Database db in list)
            {
                Button btn = new Button();
                btn.Text = db.name;
                btn.Tag = db.id;

                btn.Size = new Size { Width = flp_ListDb.Width - 2, Height = 50 };
                btn.Click += Btn_Db_Click;
                flp_ListDb.Controls.Add(btn);
            }
            curentDB = new Database()
            {
                id = int.Parse(list[0].id.ToString()),
                name = list[0].name.ToString()
            };
        }

        private void Btn_Db_Click(object sender, EventArgs e)
        {
            Button btn_clicked = sender as Button;

            lbl_DbName.Text = btn_clicked.Text;

            curentDB = new Database()
            {
                id = int.Parse(btn_clicked.Tag.ToString()),
                name = btn_clicked.Text.ToString()
            };
            setListBK();
        }

        public static List<Database> getListDB()
        {
            String query = "USE Master SELECT database_id, name " +
                            "FROM sys.databases WHERE(database_id >= 5) AND(NOT(name LIKE N'ReportServer%')) " +
                            "ORDER BY NAME";
            try
            {
                using (SqlConnection cnn = new SqlConnection(Program.GetConectionString()))
                using (SqlCommand comm = new SqlCommand(query, cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = comm.ExecuteReader();

                    List<Database> listDB = new List<Database>();

                    while (reader.Read())
                    {
                        Database db = new Database
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1)

                        };
                        listDB.Add(db);
                    }

                    reader.Close();
                    reader.Dispose();

                    return listDB;
                }
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
        }

        public static List<BackupInfo> getVersionBKList()
        {
            String query = "SELECT position, description, backup_start_date , user_name " +
                            "FROM msdb.dbo.backupset " +
                            "WHERE  database_name = '"+ curentDB.name +"' AND type = 'D' " +
                            "AND backup_set_id > (SELECT MAX(backup_set_id) " +
                                                "FROM msdb.dbo.backupset " +
                                                "WHERE media_set_id = " +
                                                    "(SELECT  MAX(media_set_id)" +
                                                    " FROM msdb.dbo.backupset " +
                                                    "WHERE database_name = '"+ curentDB.name +"' AND type = 'D') AND position = 1)" +
                            "ORDER BY position DESC";
            try
            {
                using (SqlConnection cnn = new SqlConnection(Program.GetConectionString()))
                using (SqlCommand comm = new SqlCommand(query, cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = comm.ExecuteReader();

                    List<BackupInfo> listBK = new List<BackupInfo>();

                    while (reader.Read())
                    {
                        BackupInfo bk = new BackupInfo
                        {
                            position = reader.GetInt32(0),
                            description = reader.GetString(1),
                            backupDateTime = reader.GetDateTime(2),
                            userBackup = reader.GetString(3)
                        };
                        listBK.Add(bk);
                    }

                    reader.Close();
                    reader.Dispose();

                    return listBK;
                }
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
        }

        private void InvokeUI(Action action)
        {
            if (!this.IsDisposed)
            {
                try
                {
                    this.Invoke(action);
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        public void setListBK()
        {
            lsv_BackupVersions.Items.Clear();
            lsv_BackupVersions.View = View.Details;
            lsv_BackupVersions.OwnerDraw = true;

            List<BackupInfo> backupInfos = getVersionBKList();
            lbl_BackupCount.Text = backupInfos.Count.ToString();

            foreach (var item in backupInfos)
            {
                ListViewItem row = new ListViewItem(new string[] { item.position.ToString(), item.description, item.backupDateTime.ToString("MM/dd/yyyy HH:mm:ss"), item.userBackup });

                lsv_BackupVersions.Items.Add(row);
            }
        }

/*        public bool CreateDevice()
        {
            String currentPath = this.GetType().Assembly.Location;

            String folderPath = currentPath.Substring(0, currentPath.LastIndexOf("\\"));

            DirectoryInfo directoryInfo = null;
            if (!Directory.Exists($"{folderPath}\\BackupFiles\\{curentDB.name}"))
            {
                directoryInfo = Directory.CreateDirectory($"{folderPath}\\BackupFiles\\{curentDB.name}");
            }

            if (directoryInfo == null)
            {
                QueryStrings.CurrentPathDevice = $"{folderPath}\\BackupFiles\\{curentDB.name}\\{curentDB.name}.bak";
            }
            else
            {
                QueryStrings.CurrentPathDevice = $"{directoryInfo.FullName}\\{curentDB.name}.bak";
            }

            IEnumerable<Boolean> result = ExecuteQuery<Boolean>.Execute(ConnectionInfo, QueryStrings.CreateDevice, (sqlDataReader) =>
            {
                return SqlSupport.Read<Boolean>(sqlDataReader, "");
            });

            this.CurrentDataBase = _currentDB;

            return result.FirstOrDefault();
        }*/

    }
}
