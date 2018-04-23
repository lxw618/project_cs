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
    public partial class FamilyInstance : Form
    {
        public FamilyInstance()
        {
            InitializeComponent();
        }

        private void FamilyInstance_Load(object sender, EventArgs e)
        {
            listIncomeItem.Items.Clear();
            listOutcomeItem.Items.Clear();
            DateTime dt = DateTime.Today;
            string dtStrStart = dt.ToString("yyyy-1-1");
            string dtStrEnd = dt.AddYears(1).ToString("yyyy-1-1");
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select [username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "# order by [date]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Money");
                dgvFamilyYear.DataSource = ds.Tables["Money"];
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
                string sqlcommand = "select [username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and[type]='收入' order by [date]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Money");
                dgvIn.DataSource = ds.Tables["Money"];
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
                string sqlcommand = "select [username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and[type]='支出' order by [date]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Money");
                dgvOut.DataSource = ds.Tables["Money"];
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
                string sqlcommand = "select distinct [item] from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='收入'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    listIncomeItem.Items.Add(reader.GetString(0));
                }
                string sqlcommandB = "select distinct [item] from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='支出'";                               
                OleDbCommand bCommand = new OleDbCommand(sqlcommandB, aConnection);
                OleDbDataReader breader = bCommand.ExecuteReader();
                while (breader.Read())
                {
                    listOutcomeItem.Items.Add(breader.GetString(0));
                }
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
                lbIncome.Text = strIncome + "元";
                string sqlcommandD = "select sum([money]) from [Money] where [date]>=#" + dtStrStart + "# and [date]<#" + dtStrEnd + "#  and [type]='支出'";
                OleDbCommand dCommand = new OleDbCommand(sqlcommandD, aConnection);
                OleDbDataReader dreader = dCommand.ExecuteReader();
                dreader.Read();
                strOutcome = dreader.GetValue(0).ToString();
                if (strOutcome == "")
                {
                    strOutcome = "0";
                }
                lbOutcome.Text = strOutcome + "元";
                strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                lbGet.Text = strGet + "元";
                aConnection.Close();
            }
            catch 
            {
                MessageBox.Show("没有收支数据", "系统错误");
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            this.FamilyInstance_Load(sender, e);
        }


    }
}
