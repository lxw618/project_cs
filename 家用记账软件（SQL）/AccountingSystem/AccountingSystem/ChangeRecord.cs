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
    public partial class ChangeRecord : Form
    {
        public ChangeRecord()
        {
            InitializeComponent();
        }
        public void GetAuthority()
        {
            
            
            cmbType.Text = "收入";
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
                dgvChangeRecord.DataSource = ds.Tables["Account"];
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
                dptDate.Value = reader.GetDateTime(0);
                txtMoney.Text = reader.GetValue(1).ToString();
                cmbItem.Text = reader.GetString(2);
                cmbType.Text = reader.GetString(3);
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

        public void FillItem()
        {
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
                //cmbItem.Text = cmbItem.Items[0].ToString();
            }
            catch
            {
                return;
            }
        }

        public void ClearContent()
        {            
            txtMoney.Text = "";
            txtMemo.Text = "";
        }

        private void ChangeRecord_Load(object sender, EventArgs e)
        {
            string username = (string)this.ParentForm.Tag;                       
            this.GetAuthority();
            this.GetUserList();
            cmbUsername.Text = username;
            this.FillDgv();
            this.FillId();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.GetAuthority();                      
            this.FillDgv();
            this.FillId();
            this.ClearContent();
        }

        private void cmbUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            this.GetAuthority();
            this.FillDgv();
            this.FillId();
            this.ClearContent();
        }

        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            this.FillIdRecordInfor();
            this.FillItem();
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
            this.FillItem();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cmbId.Text == "" || txtMoney.Text == "" || cmbItem.Text == "")
            {
                MessageBox.Show("请将数据号、金额、收支项目填写完整", "系统错误");
                return;
            }
            try
            {
                DateTime dt = dptDate.Value;
                string dtStr = dt.ToString("yyyy-MM-dd");
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "update [Account] set [date]='" + dtStr + "',[money]=" + txtMoney.Text + ",[item]='" + cmbItem.Text + "',[type]='" + cmbType.Text + "',[memo]='" + txtMemo.Text + "' where ID=" + cmbId.Text;
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                this.ClearContent();
                this.GetAuthority();
                this.FillDgv();
                this.FillId();
                MessageBox.Show("修改成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
                this.ChangeRecord_Load(sender, e);
                return;
            }
        }
    }
}
