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
    public partial class TypeCase : Form
    {
        string accountstyle;
        public TypeCase()
        {
            InitializeComponent();
        }

        public void FillUsername()
        {
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
                return;
            }
        }

        public void GetAuthority()
        {
            string username = (string)this.ParentForm.Tag;

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
                    cmbRange.Enabled = false;
                    cmbUsername.Enabled = false;
                }
                else if (accountstyle == "管理员")
                {

                    cmbRange.Enabled = true;
                }
            }
            catch
            {
                return;
            }
        }

        public void getItem()
        {
            cmbItem.Items.Clear();
            try
            {
                if (cmbType.Text == "所有")
                {
                    cmbItem.Text = "所有";
                    cmbItem.Enabled = false;
                }
                else
                {
                    cmbItem.Enabled = true;
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
                    cmbItem.Items.Add("所有");
                    reader.Close();
                }
                cmbItem.Text = cmbItem.Items[0].ToString();
            }
            catch
            {
                return;
            }
        }

        public void FillDgvFamily()
        {
            try
            {
                DateTime dt = dtpDateRange.Value;
                string dtStrStart;
                string dtStrEnd;
                if (cmbWay.Text== "按年统计")
                {
                    dtStrStart = dt.ToString("yyyy-1-1");
                    dtStrEnd = dt.AddYears(1).ToString("yyyy-1-1");
                }
                else if (cmbWay.Text == "按月统计")
                {
                    dtStrStart = dt.ToString("yyyy-MM-1");
                    dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                }
                else
                {
                    dtStrStart = dt.ToString("yyyy-MM-dd");
                    dtStrEnd = dt.AddDays(1).ToString("yyyy-MM-dd");
                }
                string strType,strItem;
                if (cmbType.Text == "所有")
                {
                    strType = "";
                }
                else
                {
                    strType = " and [type]='"+cmbType.Text+"'";
                }
                if (cmbItem.Text == "所有")
                {
                    strItem = "";
                }
                else
                {
                    strItem = " and [item]='"+cmbItem.Text+"'";
                }
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [id] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Account] where [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "'"+strType+strItem+" order by [id]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Account");
                dgvStatistics.DataSource = ds.Tables["Account"];
                SqlCommandBuilder cbAccount = new SqlCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        public void FillDgvPer()
        {
            try
            {
                DateTime dt = dtpDateRange.Value;
                string dtStrStart;
                string dtStrEnd;
                if (cmbWay.Text == "按年统计")
                {
                    dtStrStart = dt.ToString("yyyy-1-1");
                    dtStrEnd = dt.AddYears(1).ToString("yyyy-1-1");
                }
                else if (cmbWay.Text == "按月统计")
                {
                    dtStrStart = dt.ToString("yyyy-MM-1");
                    dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                }
                else
                {
                    dtStrStart = dt.ToString("yyyy-MM-dd");
                    dtStrEnd = dt.AddDays(1).ToString("yyyy-MM-dd");
                }
                string strType, strItem;
                if (cmbType.Text == "所有")
                {
                    strType = "";
                }
                else
                {
                    strType = " and [type]='" + cmbType.Text + "'";
                }
                if (cmbItem.Text == "所有")
                {
                    strItem = "";
                }
                else
                {
                    strItem = " and [item]='" + cmbItem.Text + "'";
                }
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [id] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Account] where [username]='" + cmbUsername.Text + "' and [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "'"+strType+strItem+" order by [id]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Account");
                dgvStatistics.DataSource = ds.Tables["Account"];
                SqlCommandBuilder cbAccount = new SqlCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        public void TotalPer()
        {
            try
            {
                DateTime dt = dtpDateRange.Value;
                string dtStrStart;
                string dtStrEnd;
                if (cmbWay.Text == "按年统计")
                {
                    dtStrStart = dt.ToString("yyyy-1-1");
                    dtStrEnd = dt.AddYears(1).ToString("yyyy-1-1");
                }
                else if (cmbWay.Text == "按月统计")
                {
                    dtStrStart = dt.ToString("yyyy-MM-1");
                    dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                }
                else
                {
                    dtStrStart = dt.ToString("yyyy-MM-dd");
                    dtStrEnd = dt.AddDays(1).ToString("yyyy-MM-dd");
                }
                string strType, strItem;
                if (cmbType.Text == "所有")
                {
                    strType = "";
                }
                else
                {
                    strType = " and [type]='" + cmbType.Text + "'";
                }
                if (cmbItem.Text == "所有")
                {
                    strItem = "";
                }
                else
                {
                    strItem = " and [item]='" + cmbItem.Text + "'";
                }
                string strIncome, strOutcome;
                string strGet;
                if (cmbType.Text == "收入")
                {
                    string connectstring = frmLogOn.f0.sqlConectstring;
                    SqlConnection aConnection = new SqlConnection(connectstring);
                    aConnection.Open();
                    string sqlcommandC = "select sum([money]) from [Account] where [username]='" + cmbUsername.Text + "' and [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "'" + strType + strItem;
                    SqlCommand cCommand = new SqlCommand(sqlcommandC, aConnection);
                    SqlDataReader creader = cCommand.ExecuteReader();
                    creader.Read();                   
                    strIncome = creader.GetValue(0).ToString();
                    if (strIncome == "")
                    {
                        strIncome = "0";
                        creader.Close();
                    }
                    strOutcome = "0";
                    strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                }
                else if (cmbType.Text == "支出")
                {
                    string connectstring = frmLogOn.f0.sqlConectstring;
                    SqlConnection aConnection = new SqlConnection(connectstring);
                    aConnection.Open();
                    string sqlcommandD = "select sum([money]) from [Account] where [username]='" + cmbUsername.Text + "' and [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "'" + strType + strItem;
                    SqlCommand dCommand = new SqlCommand(sqlcommandD, aConnection);
                    SqlDataReader dreader = dCommand.ExecuteReader();
                    dreader.Read();
                    strOutcome = dreader.GetValue(0).ToString();
                    if (strOutcome == "")
                    {
                        strOutcome = "0";
                    }
                    strIncome = "0";
                    strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                    dreader.Close();
                    aConnection.Close();
                }
                else
                {
                    string connectstring = frmLogOn.f0.sqlConectstring;
                    SqlConnection aConnection = new SqlConnection(connectstring);
                    aConnection.Open();
                    string sqlcommandC = "select sum([money]) from [Account] where [username]='" + cmbUsername.Text + "' and [date]<'" + dtStrEnd + "' and [type]='收入'" + strItem;
                    SqlCommand cCommand = new SqlCommand(sqlcommandC, aConnection);
                    SqlDataReader creader = cCommand.ExecuteReader();
                    creader.Read();
                    strIncome = creader.GetValue(0).ToString();
                    if (strIncome == "")
                    {
                        strIncome = "0";
                    }
                    creader.Close();
                    string sqlcommandD = "select sum([money]) from [Account] where [username]='" + cmbUsername.Text + "' and [date]<'" + dtStrEnd + "' and [type]='支出'" + strItem;
                    SqlCommand dCommand = new SqlCommand(sqlcommandD, aConnection);
                    SqlDataReader dreader = dCommand.ExecuteReader();
                    dreader.Read();
                    strOutcome = dreader.GetValue(0).ToString();
                    if (strOutcome == "")
                    {
                        strOutcome = "0";
                    }
                    strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                    dreader.Close();
                    aConnection.Close();
                }
                lbTotal.Text = "表中项目共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "wrong");
                lbTotal.Text = "没有收支统计数据";
            }
        }

        public void TotalFamily()
        {
            try
            {

                DateTime dt = dtpDateRange.Value;
                string dtStrStart;
                string dtStrEnd;
                if (cmbWay.Text == "按年统计")
                {
                    dtStrStart = dt.ToString("yyyy-1-1");
                    dtStrEnd = dt.AddYears(1).ToString("yyyy-1-1");
                }
                else if (cmbWay.Text == "按月统计")
                {
                    dtStrStart = dt.ToString("yyyy-MM-1");
                    dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                }
                else
                {
                    dtStrStart = dt.ToString("yyyy-MM-dd");
                    dtStrEnd = dt.AddDays(1).ToString("yyyy-MM-dd");
                }
                string strType, strItem;
                if (cmbType.Text == "所有")
                {
                    strType = "";
                }
                else
                {
                    strType = " and [type]='" + cmbType.Text + "'";
                }
                if (cmbItem.Text == "所有")
                {
                    strItem = "";
                }
                else
                {
                    strItem = " and [item]='" + cmbItem.Text + "'";
                }
                string strIncome, strOutcome;
                string strGet;
                if (cmbType.Text == "收入")
                {
                    string connectstring = frmLogOn.f0.sqlConectstring;
                    SqlConnection aConnection = new SqlConnection(connectstring);
                    aConnection.Open();
                    string sqlcommandC = "select sum([money]) from [Account] where [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "'" + strType + strItem;
                    SqlCommand cCommand = new SqlCommand(sqlcommandC, aConnection);
                    SqlDataReader creader = cCommand.ExecuteReader();
                    creader.Read();
                    strIncome = creader.GetValue(0).ToString();
                    if (strIncome == "")
                    {
                        strIncome = "0";
                        creader.Close();
                    }
                    strOutcome = "0";
                    strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                }
                else if (cmbType.Text == "支出")
                {
                    string connectstring = frmLogOn.f0.sqlConectstring;
                    SqlConnection aConnection = new SqlConnection(connectstring);
                    aConnection.Open();
                    string sqlcommandD = "select sum([money]) from [Account] where [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "'" + strType + strItem;
                    SqlCommand dCommand = new SqlCommand(sqlcommandD, aConnection);
                    SqlDataReader dreader = dCommand.ExecuteReader();
                    dreader.Read();
                    strOutcome = dreader.GetValue(0).ToString();
                    if (strOutcome == "")
                    {
                        strOutcome = "0";
                    }
                    strIncome = "0";
                    strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                    dreader.Close();
                    aConnection.Close();
                }
                else
                {
                    string connectstring = frmLogOn.f0.sqlConectstring;
                    SqlConnection aConnection = new SqlConnection(connectstring);
                    aConnection.Open();
                    string sqlcommandC = "select sum([money]) from [Account] where [date]<'" + dtStrEnd + "' and [type]='收入'" + strItem;
                    SqlCommand cCommand = new SqlCommand(sqlcommandC, aConnection);
                    SqlDataReader creader = cCommand.ExecuteReader();
                    creader.Read();
                    strIncome = creader.GetValue(0).ToString();
                    if (strIncome == "")
                    {
                        strIncome = "0";
                    }
                    creader.Close();
                    string sqlcommandD = "select sum([money]) from [Account] where [date]<'" + dtStrEnd + "' and [type]='支出'" + strItem;
                    SqlCommand dCommand = new SqlCommand(sqlcommandD, aConnection);
                    SqlDataReader dreader = dCommand.ExecuteReader();
                    dreader.Read();
                    strOutcome = dreader.GetValue(0).ToString();
                    if (strOutcome == "")
                    {
                        strOutcome = "0";
                    }
                    strGet = (double.Parse(strIncome) - double.Parse(strOutcome)).ToString();
                    dreader.Close();
                    aConnection.Close();
                }
                lbTotal.Text = "表中项目共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "wrong");
                lbTotal.Text = "没有收支统计数据";
            }
        }

        private void TypeCase_Load(object sender, EventArgs e)
        {
            this.FillUsername();
            cmbUsername.Text = (string)this.ParentForm.Tag;
            cmbRange.Text = "个人";
            cmbWay.Text = "按日统计";
            cmbType.Text = "收入";
            this.getItem();
            this.GetAuthority();
            this.FillDgvPer();
            this.TotalPer();


        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.getItem();
            if (cmbRange.Text == "个人")
            {
                this.FillDgvPer();
                this.TotalPer();
                cmbUsername.Enabled = true;
            }
            else
            {
                this.FillDgvFamily();
                this.TotalFamily();
                cmbUsername.Enabled = false;
            }
        }

        private void cmbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {               
                this.FillDgvPer();
                this.TotalPer();
                cmbUsername.Enabled = true;
            }
            else
            {
                this.FillDgvFamily();
                this.TotalFamily();
                cmbUsername.Enabled = false;
            }
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {
                this.FillDgvPer();
                this.TotalPer();
                cmbUsername.Enabled = true;
            }
            else
            {
                this.FillDgvFamily();
                this.TotalFamily();
                cmbUsername.Enabled = false;
            }
        }

        private void cmbWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {
                this.FillDgvPer();
                this.TotalPer();
                cmbUsername.Enabled = true;
            }
            else
            {
                this.FillDgvFamily();
                this.TotalFamily();
                cmbUsername.Enabled = false;
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {
                this.FillDgvPer();
                this.TotalPer();
                cmbUsername.Enabled = true;
            }
            else
            {
                this.FillDgvFamily();
                this.TotalFamily();
                cmbUsername.Enabled = false;
            }
        }

        private void dtpDateRange_ValueChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {
                this.FillDgvPer();
                this.TotalPer();
                cmbUsername.Enabled = true;
            }
            else
            {
                this.FillDgvFamily();
                this.TotalFamily();
                cmbUsername.Enabled = false;
            }
        }

        private void cmbItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (cmbRange.Text == "个人")
                {
                    this.FillDgvPer();
                    this.TotalPer();
                    cmbUsername.Enabled = true;
                }
                else
                {
                    this.FillDgvFamily();
                    this.TotalFamily();
                    cmbUsername.Enabled = false;
                }
                e.Handled = true;
            }
        }
    }
}
