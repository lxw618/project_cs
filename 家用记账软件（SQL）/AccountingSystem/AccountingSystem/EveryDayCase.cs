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
    public partial class EveryDayCase : Form
    {
        string accountstyle; 
        public EveryDayCase()
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
            DateTime dt = dtpDate.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [id] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Account] where [username]='" + cmbUsername.Text + "' and [date]='" + dtStr + "' order by [id]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Account");
                dgvEachDay.DataSource = ds.Tables["Account"];
                SqlCommandBuilder cbAccount = new SqlCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        public void FillDgvFamily()
        {
            DateTime dt = dtpDate.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [id] as 数据号,[username] as 用户名,[date] as 收支日期,[money] as 金额,[item] as 收支项目,[type] as 收支类型,[memo] as 备注 from [Account] where [date]='" + dtStr + "' order by [id]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sqlcommand, connectstring);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Account");
                dgvEachDay.DataSource = ds.Tables["Account"];
                SqlCommandBuilder cbAccount = new SqlCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        public void TotalPer()
        {
            DateTime dt = dtpDate.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                string sqlcommandC = "select sum([money]) from [Account] where [username]='" + cmbUsername.Text + "' and [date]='" + dtStr + "' and [type]='收入'";
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
                string sqlcommandD = "select sum([money]) from [Account] where [username]='" + cmbUsername.Text + "' and [date]='" + dtStr + "' and [type]='支出'";
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
                lbTotal.Text = "当日共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
                aConnection.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString(),"wrong");
                lbTotal.Text = "没有收支统计数据";
            }
        }

        public void TotalFamily()
        {
            DateTime dt = dtpDate.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                string sqlcommandC = "select sum([money]) from [Account] where [date]='" + dtStr + "' and [type]='收入'";
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
                string sqlcommandD = "select sum([money]) from [Account] where [date]='" + dtStr + "' and [type]='支出'";
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
                lbTotal.Text = "当日共收入" + strIncome + "元，支出" + strOutcome + "元，盈余" + strGet + "元。";
                aConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "wrong");
                lbTotal.Text = "没有收支统计数据";
            }
        }

        private void EveryDayCase_Load(object sender, EventArgs e)
        {
            cmbRange.Text = "个人";
            this.FillUsername();
            cmbUsername.Text = (string)this.ParentForm.Tag;
            this.GetAuthority();
            this.FillDgvPer();
            this.TotalPer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbRange.Text == "个人")
            {
                this.FillDgvPer();
                this.TotalPer();
            }
            else
            {
                this.FillDgvFamily();
                this.TotalFamily();
            }
        }

        private void cmbRange_SelectedValueChanged(object sender, EventArgs e)
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

        private void cmbUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            this.FillDgvPer();
            this.TotalPer();
        }
    }
}
