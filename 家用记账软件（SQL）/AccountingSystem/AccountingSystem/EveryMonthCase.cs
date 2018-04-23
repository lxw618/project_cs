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
    public partial class EveryMonthCase : Form
    {
        string accountstyle;
        public EveryMonthCase()
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

        public void FillDgvPer()
        {
            try
            {
                DateTime dt = Convert.ToDateTime(cmbYear.Text + "-" + cmbMonth.Text + "-1");
                string dtStrStart = dt.ToString("yyyy-MM-1");
                string dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [id] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Account] where [username]='" + cmbUsername.Text + "' and [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "' order by [id]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Account");
                dgvEachMonth.DataSource = ds.Tables["Account"];
                SqlCommandBuilder cbAccount = new SqlCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        public void FillDgvFamily()
        {
            try
            {
                DateTime dt = Convert.ToDateTime(cmbYear.Text + "-" + cmbMonth.Text + "-1");
                string dtStrStart = dt.ToString("yyyy-MM-1");
                string dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [id] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Account] where [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "' order by [id]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Account");
                dgvEachMonth.DataSource = ds.Tables["Account"];
                SqlCommandBuilder cbAccount = new SqlCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        public void YearCheck()
        {
            if (Convert.ToInt32(cmbYear.Text) < 1753)
            {
                MessageBox.Show("年份不能小于1753年", "错误");
                cmbYear.Text = "1753";
            }
            else if (Convert.ToInt32(cmbYear.Text) == 9999 & cmbMonth.Text == "12")
            {
                MessageBox.Show("当年份为9999年时，月份为12月份会使程序加一月操作出错", "错误");
                cmbYear.Text = "9998";
            }
        }

        public void TotalPer()
        {
            
            try
            {
                DateTime dt = Convert.ToDateTime(cmbYear.Text + "-" + cmbMonth.Text + "-1");
                string dtStrStart = dt.ToString("yyyy-MM-1");
                string dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                string connectstring = frmLogOn.f0.sqlConectstring;
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                string sqlcommandC = "select sum([money]) from [Account] where [username]='" + cmbUsername.Text + "' and [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "' and [type]='收入'";
                SqlCommand cCommand = new SqlCommand(sqlcommandC, aConnection);
                SqlDataReader creader = cCommand.ExecuteReader();
                creader.Read();
                string strIncome, strOutcome;
                string strGet;
                strIncome = creader.GetValue(0).ToString();
                if (strIncome == "")
                {
                    strIncome = "0";
                }
                creader.Close();
                string sqlcommandD = "select sum([money]) from [Account] where [username]='" + cmbUsername.Text + "' and [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "' and [type]='支出'";
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
                lbTotal.Text = "当月共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
                aConnection.Close();
            }
            catch 
            {                
                lbTotal.Text = "没有收支统计数据";
            }
        }

        public void TotalFamily()
        {
            
            try
            {
                DateTime dt = Convert.ToDateTime(cmbYear.Text + "-" + cmbMonth.Text + "-1");
                string dtStrStart = dt.ToString("yyyy-MM-1");
                string dtStrEnd = dt.AddMonths(1).ToString("yyyy-MM-1");
                string connectstring = frmLogOn.f0.sqlConectstring;
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                string sqlcommandC = "select sum([money]) from [Account] where [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "' and [type]='收入'";
                SqlCommand cCommand = new SqlCommand(sqlcommandC, aConnection);
                SqlDataReader creader = cCommand.ExecuteReader();
                creader.Read();
                string strIncome, strOutcome;
                string strGet;
                strIncome = creader.GetValue(0).ToString();
                if (strIncome == "")
                {
                    strIncome = "0";
                }
                creader.Close();
                string sqlcommandD = "select sum([money]) from [Account] where [date]>='" + dtStrStart + "' and [date]<'" + dtStrEnd + "' and [type]='支出'";
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
                lbTotal.Text = "当月共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
                aConnection.Close();
            }
            catch 
            {
                
                lbTotal.Text = "没有收支统计数据";
            }
        }

        private void EveryMonthCase_Load(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Today;
            cmbYear.Text = dt.Date.Year.ToString();
            cmbMonth.Text = dt.Date.Month.ToString();                       
            this.FillUsername();
            cmbUsername.Text = (string)this.ParentForm.Tag;
            cmbRange.Text = "个人";
            this.GetAuthority();
            this.FillDgvPer();
        }

        private void cmbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {
                this.YearCheck();
                this.FillDgvPer();
                this.TotalPer();
            }
            else
            {
                this.YearCheck();
                this.FillDgvFamily();
                this.TotalFamily();
            }
        }

        private void cmbRange_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {
                this.YearCheck();
                this.FillDgvPer();
                this.TotalPer();
                cmbUsername.Enabled = true;
            }
            else
            {
                this.YearCheck();
                this.FillDgvFamily();
                this.TotalFamily();
                cmbUsername.Enabled = false;
            }
        }

        private void cmbUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            this.YearCheck();
            this.FillDgvPer();
            this.TotalPer();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {
                this.YearCheck();
                this.FillDgvPer();
                this.TotalPer();
                
            }
            else
            {
                this.YearCheck();
                this.FillDgvFamily();
                this.TotalFamily();                
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.Text == "")
            {
                return;
            }
            if (cmbRange.Text == "个人")
            {
                this.YearCheck();
                this.FillDgvPer();
                this.TotalPer();

            }
            else
            {
                this.YearCheck();
                this.FillDgvFamily();
                this.TotalFamily();                
            }
        }

    }
}
