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
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text == "" || cmbItem.Text == "")
            {
                MessageBox.Show("请将金额和收支项目填写完整", "系统错误");
                return;
            }
            DateTime dt = dtpDate.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "insert into [Account]([username],[date],[money],[item],[type],[memo]) values('" + cmbUsername.Text + "','" + dtStr + "'," + txtMoney.Text + ",'" + cmbItem.Text + "','" + cmbType.Text + "','" + txtMemo.Text + "')";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                txtMoney.Text = "0";
                txtMemo.Text = "";
                MessageBox.Show("添加成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            cmbType.Text = "收入";
            cmbUsername.Items.Clear();
            string username = (string)this.ParentForm.Tag;
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
            cmbUsername.Text = username;
            cmbItem.Items.Clear();
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select item from [Item] where type='" + cmbType.Text.Trim() + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbItem.Items.Add(reader.GetString(0));
                }
                cmbItem.Text = cmbItem.Items[0].ToString();
            }
            catch
            {
                return;
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (txtMoney.Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else if (txtMoney.Text == "" && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '\b' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbItem.Items.Clear();
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select item from [Item] where type='"+cmbType.Text.Trim()+"'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbItem.Items.Add(reader.GetString(0));
                }
                cmbItem.Text = cmbItem.Items[0].ToString();
            }
            catch
            {
                return;
            }
            
        }
    }
}
