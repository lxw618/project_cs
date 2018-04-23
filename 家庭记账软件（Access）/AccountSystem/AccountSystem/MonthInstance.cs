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
    public partial class MonthInstance : Form
    {
        public MonthInstance()
        {
            InitializeComponent();
        }

        private void MonthInstance_Load(object sender, EventArgs e)
        {
            cmbRange.Text = "个人";
            cmbUsername.Items.Clear();
            string username = (string)this.ParentForm.Tag;
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
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
                return;
            }
            cmbUsername.Text = username;
            
        }

        private void cmbRange_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "家庭")
            {
                cmbUsername.Enabled = false;
                DateTime dt = DateTime.Today;
                string dtStrStart = dt.ToString("yyyy-MM-1");
                string dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                try
                {
                    string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                    string sqlcommand = "select [username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "# order by [date]";
                    OleDbConnection aConnection = new OleDbConnection(connectstring);
                    aConnection.Open();
                    OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Money");
                    dgvInstance.DataSource = ds.Tables["Money"];
                    OleDbCommandBuilder cbMoney = new OleDbCommandBuilder(adp);
                    aConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "系统错误");
                }
                try
                {
                    string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                    OleDbConnection aConnection = new OleDbConnection(connectstring);
                    aConnection.Open();
                    string sqlcommandC = "select sum([money]) from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='收入'";
                    OleDbCommand cCommand = new OleDbCommand(sqlcommandC, aConnection);
                    OleDbDataReader creader = cCommand.ExecuteReader();
                    creader.Read();
                    string strIncome, strOutcome;
                    string strGet;
                    strIncome = creader.GetValue(0).ToString();
                    if (strIncome == "")
                    {
                        strIncome = "0";
                    }
                    string sqlcommandD = "select sum([money]) from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='支出'";
                    OleDbCommand dCommand = new OleDbCommand(sqlcommandD, aConnection);
                    OleDbDataReader dreader = dCommand.ExecuteReader();
                    dreader.Read();
                    strOutcome = dreader.GetValue(0).ToString();
                    if (strOutcome == "")
                    {
                        strOutcome = "0";
                    }
                    strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                    lbGet.Text = "本月家庭共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
                    aConnection.Close();
                }
                catch 
                {
                    lbGet.Text = "没有收支统计数据";
                }

            }
            else
            {
                cmbUsername.Enabled = true;
                DateTime dt = DateTime.Today;
                string dtStrStart = dt.ToString("yyyy-MM-1");
                string dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                try
                {
                    string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                    string sqlcommand = "select [username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [username]='" + cmbUsername.Text + "' and [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "# order by [date]";
                    OleDbConnection aConnection = new OleDbConnection(connectstring);
                    aConnection.Open();
                    OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Money");
                    dgvInstance.DataSource = ds.Tables["Money"];
                    OleDbCommandBuilder cbMoney = new OleDbCommandBuilder(adp);
                    aConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "系统错误");
                }
                try
                {
                    string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                    OleDbConnection aConnection = new OleDbConnection(connectstring);
                    aConnection.Open();
                    string sqlcommandC = "select sum([money]) from [Money] where [username]='" + cmbUsername.Text + "' and [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='收入'";
                    OleDbCommand cCommand = new OleDbCommand(sqlcommandC, aConnection);
                    OleDbDataReader creader = cCommand.ExecuteReader();
                    creader.Read();
                    string strIncome, strOutcome;
                    string strGet;
                    strIncome = creader.GetValue(0).ToString();
                    if (strIncome == "")
                    {
                        strIncome = "0";
                    }
                    string sqlcommandD = "select sum([money]) from [Money] where [username]='" + cmbUsername.Text + "' and [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='支出'";
                    OleDbCommand dCommand = new OleDbCommand(sqlcommandD, aConnection);
                    OleDbDataReader dreader = dCommand.ExecuteReader();
                    dreader.Read();
                    strOutcome = dreader.GetValue(0).ToString();
                    if (strOutcome == "")
                    {
                        strOutcome = "0";
                    }
                    strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                    lbGet.Text = "本月共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
                    aConnection.Close();
                }
                catch 
                {
                    lbGet.Text = "没有收支统计数据";
                }
            }
        }

        private void cmbUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            string dtStrStart = dt.ToString("yyyy-MM-1");
            string dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [username]='" + cmbUsername.Text + "' and [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "# order by [date]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Money");
                dgvInstance.DataSource = ds.Tables["Money"];
                OleDbCommandBuilder cbMoney = new OleDbCommandBuilder(adp);
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                string sqlcommandC = "select sum([money]) from [Money] where [username]='" + cmbUsername.Text + "' and [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='收入'";
                OleDbCommand cCommand = new OleDbCommand(sqlcommandC, aConnection);
                OleDbDataReader creader = cCommand.ExecuteReader();
                creader.Read();
                string strIncome, strOutcome;
                string strGet;
                strIncome = creader.GetValue(0).ToString();
                if (strIncome == "")
                {
                    strIncome = "0";
                }
                string sqlcommandD = "select sum([money]) from [Money] where [username]='" + cmbUsername.Text + "' and [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='支出'";
                OleDbCommand dCommand = new OleDbCommand(sqlcommandD, aConnection);
                OleDbDataReader dreader = dCommand.ExecuteReader();
                dreader.Read();
                strOutcome = dreader.GetValue(0).ToString();
                if (strOutcome == "")
                {
                    strOutcome = "0";
                }
                strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                lbGet.Text = "本月共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
                aConnection.Close();
            }
            catch 
            {
                lbGet.Text = "没有收支统计数据";
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            this.cmbRange_SelectedValueChanged(sender, e);
        }
    }
}
