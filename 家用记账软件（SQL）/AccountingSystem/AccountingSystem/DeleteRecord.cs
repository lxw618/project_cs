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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        public void GetAuthority()
        {            
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
        }

        public void GetUserList()
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

        public void FillDgv()
        {
            DateTime dt = dtpDateSearch.Value;
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
                dgvDeleteRecord.DataSource = ds.Tables["Account"];
                SqlCommandBuilder cbAccount = new SqlCommandBuilder(adp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }

        }

        public void FillId()
        {
            cmbId.Items.Clear();
            DateTime dt = dtpDateSearch.Value;
            string dtStr = dt.ToString("yyyy-MM-dd");
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [id] from [Account] where [username]='" + cmbUsername.Text + "' and [date]='" + dtStr + "' order by [id]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbId.Items.Add(reader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        public void FillIdRecordInfor()
        {
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [date],[money],[item],[type],[memo] from [Account] where id=" + cmbId.Text;
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                txtDate.Text = reader.GetDateTime(0).ToString("yyyy-MM-dd");
                txtMoney.Text = reader.GetValue(1).ToString();
                txtItem.Text = reader.GetString(2);
                txtType.Text = reader.GetString(3);
                txtMemo.Text = reader.GetString(4);
                reader.Close();
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
                this.FillId();
                return;
            }
        }

        public void ClearContent()
        {
            txtDate.Text = "";
            txtType.Text = "";
            txtItem.Text = "";
            txtMoney.Text = "";
            txtMemo.Text = "";
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;
            this.GetAuthority();
            this.GetUserList();
            cmbUsername.Text = username;
            this.FillDgv();
            this.FillId();
            this.ClearContent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.GetAuthority();
            this.FillDgv();
            this.FillId();
            this.ClearContent();
        }

        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            this.FillIdRecordInfor();
        }

        private void cmbUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            this.GetAuthority();
            this.FillDgv();
            this.FillId();
            this.ClearContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbId.Text == "")
            {
                MessageBox.Show("请选择数据号", "系统错误");
                return;
            }
            try
            {

                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "delete from [Account] where id=" + cmbId.Text;
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                this.GetAuthority();
                this.FillDgv();
                this.FillId();
                this.ClearContent();
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
