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
    public partial class ChangeAccountInfo : Form
    {
        public ChangeAccountInfo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            if (txtPassword.Text == "" || txtNickname.Text == "")
            {
                MessageBox.Show("请将所有必填空格填写完整", "填写错误");
                return;
            }
            if (AccountStyle.Text=="普通" & cmbUsername.Text==username &cmbUsername.Enabled==true)
            {
                if (DialogResult.No == MessageBox.Show("确认将自己的账户权限降为普通用户？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return;                
                }
                MainForm.f1.MenuItemDeleteUser.Visible = false;
            }
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "update [User] set [password]='" + txtPassword.Text + "',[nickname]='" + txtNickname.Text + "',[truename]='" + txtTrueName.Text + "',[familycall]='" + txtFamilyCall.Text + "',[accountstyle]='" + AccountStyle.Text + "'where [username]='"+cmbUsername.Text+"'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                this.ChangeAccountInfo_Load(sender, e);
                this.ParentForm.Text = "家庭记账软件-" + txtNickname.Text;             
                MessageBox.Show("修改成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "修改失败");
                return;
            }
        }

        private void ChangeAccountInfo_Load(object sender, EventArgs e)
        {
            
            this.Text = "修改账户信息（管理员）";
            cmbUsername.Items.Clear();
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
                    cmbUsername.Enabled = false;
                    this.Text = "修改账户信息（普通）";
                }
                else if (accountstyle == "管理员")
                {
                    AccountStyle.Enabled = true;
                    cmbUsername.Enabled = true;
                    this.Text = "修改账户信息（管理员）";
                }
            }
            catch 
            {
                return;
            }
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select username from [User]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand,aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbUsername.Items.Add(reader.GetString(0));
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [username],[password],[nickname],[truename],[familycall],[accountstyle] from [User] where username='" + username + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                cmbUsername.Text = reader.GetString(0);
                txtNickname.Text = reader.GetString(2);
                txtPassword.Text = reader.GetString(1);
                txtTrueName.Text = reader.GetString(3);
                txtFamilyCall.Text=reader.GetString(4);
                AccountStyle.Text = reader.GetString(5);
                reader.Close();
                aConnection.Close();
                return;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "错误");
                return;
            }
        }

        private void cmbUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [username],[password],[nickname],[truename],[familycall],[accountstyle] from [User] where username='" + cmbUsername.Text + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                cmbUsername.Text = reader.GetString(0);
                txtNickname.Text = reader.GetString(2);
                txtPassword.Text = reader.GetString(1);
                txtTrueName.Text = reader.GetString(3);
                txtFamilyCall.Text = reader.GetString(4);
                AccountStyle.Text = reader.GetString(5);
                reader.Close();
                aConnection.Close();
                if (cmbUsername.Text == (string)this.ParentForm.Tag)
                {
                    txtPassword.ReadOnly = true;
                }
                else
                {
                    txtPassword.ReadOnly = false;
                }
                return;
            }
            catch 
            {
                this.ChangeAccountInfo_Load(sender, e);
                return;
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            string username = cmbUsername.Text;
            this.ChangeAccountInfo_Load(sender, e);
            cmbUsername.Text = username;
        }
    }
}
