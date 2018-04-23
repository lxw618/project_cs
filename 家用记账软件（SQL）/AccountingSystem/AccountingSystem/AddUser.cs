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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            cmbAccountStyle.Text = "普通";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            if(txtPassword.Text!=txtPasswordRepeat.Text)
            {
                MessageBox.Show("两次密码不一致", "输入错误");
            }
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtNickname.Text == ""|| txtPasswordRepeat.Text == "")
            {
                MessageBox.Show("请将所有必填空格填写完整", "填写错误");
                return;
            }
            string str1, str2;
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select username,nickname from [User]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand,aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
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
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "insert into [User]([username],[password],[nickname],[familycall],[accountstyle]) values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtNickname.Text + "','" + txtFamilyCall.Text + "','" + cmbAccountStyle.Text + "')";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
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
            txtPasswordRepeat.Text = "";
            txtFamilyCall.Text = "";            
        }
    }
}
