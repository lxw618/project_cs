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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void btnSearchRecord_Click(object sender, EventArgs e)
        {
            DateTime dt = dtpDate.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
            cmbID.Items.Clear();
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [ID] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [username]='" + cmbUsername.Text + "' and [date]=#" + dtStr + "# order by [ID]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Money");
                dgvChangeRecord.DataSource = ds.Tables["Money"];
                OleDbCommandBuilder cbMoney = new OleDbCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [ID] from [Money] where [username]='" + cmbUsername.Text + "' and [date]=#" + dtStr + "# order by [ID]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbID.Items.Add(reader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            cmbUsername.Items.Clear();
            cmbID.Items.Clear();
            string username = (string)this.ParentForm.Tag;
            string accountstyle;
            DateTime dt = dtpDate.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
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
                return;
            }
            cmbUsername.Text = username;
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [ID] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [username]='" + cmbUsername.Text + "' and [date]=#" + dtStr + "# order by [ID]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Money");
                dgvChangeRecord.DataSource = ds.Tables["Money"];
                OleDbCommandBuilder cbMoney = new OleDbCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [ID] from [Money] where [username]='" + cmbUsername.Text + "' and [date]=#" + dtStr + "# order by [ID]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbID.Items.Add(reader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            DateTime dt = dtpDate.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [ID] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [username]='" + cmbUsername.Text + "' and [date]=#" + dtStr + "# order by [ID]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Money");
                dgvChangeRecord.DataSource = ds.Tables["Money"];
                OleDbCommandBuilder cbMoney = new OleDbCommandBuilder(adp);

            }
            catch
            { }
            try
            {
                string username = (string)this.ParentForm.Tag;
                string accountstyle;
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
                    cmbUsername.Text = username;
                }
                else if (accountstyle == "管理员")
                {

                    cmbUsername.Enabled = true;
                }
            }
            catch
            { }
            cmbID.Items.Clear();
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [ID] from [Money] where [username]='" + cmbUsername.Text + "' and [date]=#" + dtStr + "# order by [ID]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbID.Items.Add(reader.GetInt32(0));
                }
            }
            catch
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbID.Text == "")
            {
                MessageBox.Show("请选择数据号", "系统错误");
                return;
            }
            try
            {
                
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "delete from [Money] where ID=" + cmbID.Text;
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                this.btnFresh_Click(sender, e);
                MessageBox.Show("删除成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
                this.DeleteRecord_Load(sender, e);
                return;
            }
        }
    }
}
