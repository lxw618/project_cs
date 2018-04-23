using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccountingSystem
{
    public partial class ChangePassword : Form
    {
        string accountstyle;
        string strOldPassword;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public void FillName()
        {
            cmbUsername.Items.Clear();
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select username from [User]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbUsername.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
                return;
            }
        }

        public void GetAuthority()
        {
            string username = (string)this.ParentForm.Tag;
            
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select accountstyle from [User] where username='" + username + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                accountstyle = reader.GetString(0);
                reader.Close();
                aConnection.Close();
                if (accountstyle != "管理员")
                {

                    cmbUsername.Enabled = false;
                }
                else if (accountstyle == "管理员")
                {

                    cmbUsername.Enabled = true;
                }
            }
            catch
            {
                return;
            }
        }

        public void GetOldPassword()
        {
            string username = cmbUsername.Text;

            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select password from [User] where username='" + username + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                strOldPassword = reader.GetString(0);
                reader.Close();
                aConnection.Close();               
            }
            catch
            {
                return;
            }
        }

        public Boolean TxtIsNull()
        {
            if (txtNewPassword.Text == "" || txtNewPasswordAgain.Text == ""||txtOldPassword.Text == "")
            {
                MessageBox.Show("请将密码填写完整", "填写错误");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            this.GetAuthority();
            this.FillName();
            cmbUsername.Text = (string)this.ParentForm.Tag;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (TxtIsNull() == true)
            {
                return;
            }
            this.GetOldPassword();
            if (strOldPassword != txtOldPassword.Text)
            {
                MessageBox.Show("原密码错误", "错误");
                return;
            }
            if (txtNewPassword.Text != txtNewPasswordAgain.Text)
            {
                MessageBox.Show("两次密码输入不一致", "错误");
                return;
            }
            try
            {               
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "update [User] set [password]='" + txtNewPassword.Text + "'where [username]='"+cmbUsername.Text+"'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                txtOldPassword.Text = "";
                txtNewPassword.Text="";
                txtNewPasswordAgain.Text = "";
                MessageBox.Show("修改成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");                
                return;
            }
        }
    }
}
