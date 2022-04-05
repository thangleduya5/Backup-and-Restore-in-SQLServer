using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BackupRestore
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!validateLogin()) return;
            if (!checkLogin()) return;
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private bool validateLogin()
        {
            if (txt_ServerName.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Không được để trống tên server.\n ", "", MessageBoxButtons.OK);
                return false;
            }
            if (txt_username.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Không được để trống tên đăng nhập.\n ", "", MessageBoxButtons.OK);
                return false;
            }
            if (txt_password.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập mật khẩu.\n ", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private bool checkLogin()
        {

            Program.serverName = txt_ServerName.Text;
            Program.userName = txt_username.Text;
            Program.password = txt_password.Text;

            string a = Program.GetConectionString();
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.GetConectionString()))
                {
                    connection.Open();
                    connection.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi kết nối Server.\nBạn xem lại user name và password.\n " + sqlEx.Message, "", MessageBoxButtons.OK);
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
