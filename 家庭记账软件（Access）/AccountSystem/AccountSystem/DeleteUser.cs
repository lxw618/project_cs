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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            cmbUsername.Items.Clear();
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select username from [User]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
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
                txtFamilyCall.Text = reader.GetString(4);
                txtAccountStyle.Text = reader.GetString(5);
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
                txtAccountStyle.Text = reader.GetString(5);
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
                this.DeleteUser_Load(sender, e);
                return;
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            string username = cmbUsername.Text;
            this.DeleteUser_Load(sender, e);
            cmbUsername.Text = username;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            if (cmbUsername.Text == username )
            {
                MessageBox.Show("当前已登录的用户不能删除", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;               
            }
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "delete from [User] where [username]='"+cmbUsername.Text+"'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                this.DeleteUser_Load(sender, e);
                MessageBox.Show("删除成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "删除失败");
                return;
            }
        }



    }
}
