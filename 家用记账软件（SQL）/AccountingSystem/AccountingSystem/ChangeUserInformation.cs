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
    public partial class ChangeUserInformation : Form
    {
        public ChangeUserInformation()
        {
            InitializeComponent();
        }

        private void ChangeUserInformation_Load(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            cmbUsername.Items.Clear();
            string accountstyle;
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
                    cmbAccountStyle.Enabled = false;
                    cmbUsername.Enabled = false;
                    this.Text = "修改账户信息（普通用户）";
                }
                else if (accountstyle == "管理员")
                {
                    cmbAccountStyle.Enabled = true;
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
                cmbAccountStyle.Text = reader.GetString(3);
                txtFamilyCall.Text = reader.GetString(2);
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
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [username],[nickname],[familycall],[accountstyle] from [User] where username='" + cmbUsername.Text + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                cmbUsername.Text = reader.GetString(0);
                txtNickname.Text = reader.GetString(1);
                cmbAccountStyle.Text = reader.GetString(3);
                txtFamilyCall.Text = reader.GetString(2);
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            if (txtNickname.Text == "")
            {
                MessageBox.Show("请将所有必填空格填写完整", "填写错误");
                return;
            }
            if (cmbAccountStyle.Text == "普通" & cmbUsername.Text == username & cmbUsername.Enabled == true)
            {
                if (DialogResult.No == MessageBox.Show("确认将自己的账户权限降为普通用户？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return;
                }
                frmMain.f1.MenuItemDeleteUser.Visible = false;
                frmMain.f1.MenuItemAddUser.Visible = false;
            }
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "update [User] set [nickname]='" + txtNickname.Text + "',[familycall]='" + txtFamilyCall.Text + "',[accountstyle]='" + cmbAccountStyle.Text + "'where [username]='" + cmbUsername.Text + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                this.ChangeUserInformation_Load(sender, e);
                this.ParentForm.Text = "家庭记账软件-" + txtNickname.Text;
                frmMain.f1.toolStripStatusCurrentUser.Text = "当前用户：" + txtNickname.Text;
                MessageBox.Show("修改成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "修改失败");
                return;
            }
        }
    }
}
