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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            AccountStyle.Text = "普通";
            string accountstyle;
            string username = (string)this.ParentForm.Tag;
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select accountstyle from [User] where username='" + username + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                accountstyle = reader.GetString(0);
                reader.Close();
                aConnection.Close();
                if (accountstyle != "管理员")
                {
                    AccountStyle.Enabled = false;
                }
                return;
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtNickname.Text == "")
            {
                MessageBox.Show("请将所有必填空格填写完整", "填写错误");
                return;
            }
            string str1, str2;
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select username,nickname from [User]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand,aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    str1 = reader.GetString(0);
                    str2 = reader.GetString(1);
                    if (txtUsername.Text.Trim() == str1.Trim() || txtNickname.Text.Trim() == str2.Trim())
                    {
                        
                        reader.Close();
                        aConnection.Close();
                        MessageBox.Show("用户名或昵称与已有帐号重复", "系统错误");
                        return;
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "insert into [User]([username],[password],[nickname],[truename],[familycall],[accountstyle]) values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtNickname.Text + "','" + txtTrueName.Text + "','" + txtFamilyCall.Text + "','" + AccountStyle.Text + "')";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "添加失败");
                return;
            }
            MessageBox.Show("添加成功，您所添加的账户用户名为："+txtUsername.Text+"，密码为："+txtPassword.Text+"（用户名不可更改）", "恭喜");
            txtUsername.Text = "";
            txtNickname.Text = "";
            txtPassword.Text = "";
            txtTrueName.Text = "";
            txtFamilyCall.Text = "";
        }       

    }
}
