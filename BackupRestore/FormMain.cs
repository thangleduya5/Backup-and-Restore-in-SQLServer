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
using System.Globalization;

namespace BackupRestore
{
    public partial class FormMain : Form
    {
        public static Database currentDB;
        public static BackupInfo currentBK;
        public static String currentPathDev="";
        public static String currentDev="";
        public static String folderPath = "D:\\BackupSQLServer";


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
            lbl_DbName.Text = currentDB.name;
            setListBK();
            setupButton();
        }

        public void setupButton()
        {
            String query = "SELECT name  FROM sys.backup_devices " +
                            "WHERE name = 'DEV_" + currentDB.name +"'";
            try
            {
                using (SqlConnection cnn = new SqlConnection(Program.GetConectionString()))
                using (SqlCommand comm = new SqlCommand(query, cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    currentDev = "";
                    while (reader.Read())
                    {
                        currentDev = reader.GetString(0);
                        currentPathDev = $"{folderPath}\\{currentDB.name}\\{currentDB.name}.bak";
                    }

                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
            if (currentDev.Equals(""))
            {
                btn_CreateDevice.Enabled = true;
                btn_Backup.Enabled = false;
            } 
            else {
                btn_CreateDevice.Enabled = false;
                btn_Backup.Enabled = true;
            }    
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
            currentDB = new Database()
            {
                id = int.Parse(list[0].id.ToString()),
                name = list[0].name.ToString()
            };
            currentDev = "DEV_" + currentDB.name;
        }

        private void Btn_Db_Click(object sender, EventArgs e)
        {
            Button btn_clicked = sender as Button;

            lbl_DbName.Text = btn_clicked.Text;

            currentDB = new Database()
            {
                id = int.Parse(btn_clicked.Tag.ToString()),
                name = btn_clicked.Text.ToString()
            };
            currentDev = "DEV_" + currentDB.name;
            setListBK();
            setupButton();
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
                            "WHERE  database_name='"+ currentDB.name +"' AND type='D' AND " +
                            "backup_set_id >= " +
                                "(SELECT MAX(backup_set_id) " +
                                "FROM msdb.dbo.backupset " +
                                "WHERE media_set_id = " +
                                    "(SELECT  MAX(media_set_id) " +
                                    "FROM msdb.dbo.backupset " +
                                    "WHERE database_name = '" + currentDB.name + "' AND type = 'D') " +
                                 "AND position = 1) " +
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
                            description = reader.IsDBNull(1) ? "" : reader.GetString(1),
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

            List<BackupInfo> backupInfos = getVersionBKList();
            lbl_BackupCount.Text = backupInfos.Count.ToString();

            foreach (var item in backupInfos)
            {
                ListViewItem row = new ListViewItem(new string[] { item.position.ToString(), item.description, item.backupDateTime.ToString("dd/MM/yyyy HH:mm:ss"), item.userBackup });
                lsv_BackupVersions.Items.Add(row);
            }
        }

        private void lsv_BackupVersions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (lsv_BackupVersions.SelectedItems.Count != 0)
            {
                ListViewItem item = lsv_BackupVersions.SelectedItems[0];
                string position = item.SubItems[0].Text;

                String sql = "ALTER DATABASE "+ currentDB.name +" SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE tempdb" +
                    " RESTORE DATABASE " + currentDB.name +
                    " FROM  " + currentDev +
                    " WITH FILE = "+ Int32.Parse(position) +", REPLACE" +
                    " ALTER DATABASE " + currentDB.name + " SET MULTI_USER";
                try
                {
                    Program.ExecuteNonQuery(sql);
                    MessageBox.Show("Phục hồi thành công ");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Phục hồi thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bản backup!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            String sql = "";

            if (chk_DelAllBeforeBackup.Checked)
            {
                sql = "BACKUP DATABASE " + currentDB.name + " TO " + currentDev + " WITH INIT";
            }
            else
            {
                sql = "BACKUP DATABASE " + currentDB.name + " TO " + currentDev ;
            }
            Console.WriteLine("SQL: " + sql);
            Program.ExecuteNonQuery(sql);
            setListBK();
        }

        public bool CreateDevice()
        {
            DirectoryInfo directoryInfo = null;
            if (!Directory.Exists($"{folderPath}\\{currentDB.name}"))
            {
                directoryInfo = Directory.CreateDirectory($"{folderPath}\\{currentDB.name}");
            }

            if (directoryInfo == null)
            {
                currentPathDev = $"{folderPath}\\{currentDB.name}\\{currentDB.name}.bak";
            }
            else
            {
                currentPathDev = $"{directoryInfo.FullName}\\{currentDB.name}.bak";
            }

            try
            {
                String sql = "EXEC sp_addumpdevice 'disk', 'DEV_" + currentDB.name + "', '" + currentPathDev + "'";
                Console.WriteLine(sql);
                using (SqlConnection cnn = new SqlConnection(Program.GetConectionString()))
                using (SqlCommand comm = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    SqlDataReader sqlDataReader = comm.ExecuteReader();
                    Console.WriteLine("OK đã hoàn thành");
                    cnn.Close();

                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Lỗi: " + sqlEx);
                return false;
                throw sqlEx;
            }
            return true;
        }

        private void btn_CreateDevice_Click(object sender, EventArgs e)
        {
            CreateDevice();
            setupButton();
        }

        private void btn_RestoreByTime_Click(object sender, EventArgs e)
        {
            if (lsv_BackupVersions.Items.Count != 0)
            {
                ListViewItem item = lsv_BackupVersions.Items[0];
                string position = item.SubItems[0].Text;
                DateTime dateTimeFullBK = DateTime.Parse(item.SubItems[2].Text);
                DateTime dateTimeNow = DateTime.Now;

                DateTime timeEnter = DateTime.ParseExact(dtp_TimeRestore.Text
                                            , "HH:mm:ss"
                                            , CultureInfo.InvariantCulture);

                DateTime dateEnter = DateTime.ParseExact(dtp_DateRestore.Text
                                            , "dd-MM-yyyy"
                                            , CultureInfo.InvariantCulture);

                DateTime dateTimeEnter = new DateTime(dateEnter.Year, dateEnter.Month, dateEnter.Day, timeEnter.Hour, timeEnter.Minute, timeEnter.Second);
                Console.WriteLine("dateTimeFullBK: " + dateTimeFullBK);
                Console.WriteLine("dateTimeEnter: " + dateTimeEnter);
                if (dateTimeEnter < dateTimeFullBK)
                {
                    MessageBox.Show("Thời gian phục hồi phải sau thời gian fullbackup đó.");
                    return;
                }
                else if (dateTimeEnter > DateTime.Now)
                {
                    MessageBox.Show("Thời gian phục hồi phải trước thời gian hiện tai.");
                    return;
                }
                else
                {
                    String logPath = $"{currentPathDev.Substring(0, currentPathDev.LastIndexOf("\\"))}\\{currentDB.name}.trn";
                    String firstSql = "ALTER DATABASE "+ currentDB.name +" SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                                      "BACKUP LOG " + currentDB.name + " TO DISK = '"+ logPath +"' WITH INIT USE tempdb";
                    try
                    {
                        Program.ExecuteNonQuery(firstSql);
                    } 
                    catch(SqlException sqlEx)
                    {
                        MessageBox.Show("Lỗi Backup log");
                        return;

                    }

                    String secondSql = "RESTORE DATABASE "+ currentDB.name +" FROM DISK = '"+ currentPathDev +"' WITH NORECOVERY, REPLACE";
                    try
                    {
                        Program.ExecuteNonQuery(secondSql);
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Lỗi Restore CSDL với norecovery");
                        return;
                    }

                    String thirdSql = "RESTORE DATABASE "+ currentDB.name +" FROM DISK = '" + logPath + "' WITH STOPAT = '"+ dateTimeEnter.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    try
                    {
                        Program.ExecuteNonQuery(thirdSql);
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Lỗi Restore CSDL từ file log");
                        return;

                    }

                    String lastSql = "ALTER DATABASE "+ currentDB.name +" SET MULTI_USER";
                    Program.ExecuteNonQuery(lastSql);
                    MessageBox.Show("Phục hồi thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng backup database!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
