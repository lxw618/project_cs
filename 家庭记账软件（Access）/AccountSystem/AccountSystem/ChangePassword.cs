using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccountSystem
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            string nickname;
            string username = (string)this.ParentForm.Tag;
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select nickname from [User] where username='" + username + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                nickname = reader.GetString(0);
                reader.Close();
                aConnection.Close();
                lbUsernameDisplay.Text = username;
                lbNicknameDisplay.Text = nickname;
                return;
            }
            catch { }  
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            string password;
            if (txtOldPassword.Text == "" || txtNewPassword.Text == "" || txtRepeatPassword.Text == "")
            {
                MessageBox.Show("请将所有空格填写完整", "填写错误");
                return;
            }
            else
            {
                
                try
                {
                    string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                    string sqlcommand = "select password from [User] where username='" + username + "'";
                    OleDbConnection aConnection = new OleDbConnection(connectstring);
                    aConnection.Open();
                    OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                    OleDbDataReader reader = aCommand.ExecuteReader();
                    reader.Read();
                    password = reader.GetString(0);
                    reader.Close();
                    aConnection.Close();
                    if (txtOldPassword.Text != password)
                    {
                        MessageBox.Show("原密码错误", "填写错误");
                        return;
                    }
                }
                catch { }
                if (txtNewPassword.Text != txtRepeatPassword.Text)
                {
                    MessageBox.Show("新密码两次输入不一致", "填写错误");
                    return;
                }
            }         
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "update [User] set [password]='" + txtNewPassword.Text + "' where username='" + username + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,"修改失败");
                return;
            }
            MessageBox.Show("修改成功", "恭喜");
            this.Dispose();
        }
    }
}
