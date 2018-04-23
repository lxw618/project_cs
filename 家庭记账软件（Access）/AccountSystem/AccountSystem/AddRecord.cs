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
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            cmbStyle.Text = "收入";
            cmbUsername.Items.Clear();
            string username = (string)this.ParentForm.Tag;
            string accountstyle;
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
            cmbUsername.Text = username;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text == "" || txtItem.Text == "")
            {
                MessageBox.Show("请将金额和收支项目填写完整", "系统错误");
                return;
            }
            DateTime dt = dtpDate.Value;
            string dtStr=dt.ToString("yyyy-MM-dd");
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "insert into [Money]([username],[date],[money],[item],[type],[memo]) values('"+cmbUsername.Text+"','" + dtStr + "',"+txtMoney.Text+",'"+txtItem.Text+"','"+cmbStyle.Text+"','"+txtMemo.Text+"')";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                txtMoney.Text = "0";
                txtItem.Text = "";
                txtMemo.Text = "";
                MessageBox.Show("添加成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (txtMoney.Text.Contains(".")&& e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else if (txtMoney.Text=="" && e.KeyChar == '.')
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
    }
}
