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
            }
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [username],[nickname],[familycall],[accountstyle] from [User] where username='" + username + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                cmbUsername.Text = reader.GetString(0);
                txtNickname.Text = reader.GetString(1);                                
                txtAccountStyle.Text = reader.GetString(3);
                txtFamilyCall.Text = reader.GetString(2);
                reader.Close();
                aConnection.Close();
                if (txtFamilyCall.Text == "")
                {
                    txtFamilyCall.Text = "无";
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            if (cmbUsername.Text == username)
            {
                MessageBox.Show("当前已登录的用户不能删除", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "delete from [User] where [username]='" + cmbUsername.Text + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
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

        private void cmbUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [username],[nickname],[familycall],[accountstyle] from [User] where username='" + cmbUsername.Text + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                cmbUsername.Text = reader.GetString(0);
                txtNickname.Text = reader.GetString(1);                
                txtAccountStyle.Text = reader.GetString(3);
                txtFamilyCall.Text = reader.GetString(2);
                reader.Close();
                aConnection.Close();
                if (txtFamilyCall.Text == "")
                {
                    txtFamilyCall.Text = "无";
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
                return;
            }
        }


    }
}
