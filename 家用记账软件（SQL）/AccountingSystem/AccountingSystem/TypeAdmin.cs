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
    public partial class TypeAdmin : Form
    {
        public TypeAdmin()
        {
            InitializeComponent();
        }

        public void FillList()
        {
            listIncomeType.Items.Clear();
            listOutcomeType.Items.Clear();
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommandIncome = "select item from [Item] where type='收入'";
                string sqlcommandOutcome = "select item from [Item] where type='支出'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommandIncome, aConnection);
                SqlCommand bCommand = new SqlCommand(sqlcommandOutcome, aConnection);
                SqlDataReader Incomereader = aCommand.ExecuteReader();
                while (Incomereader.Read())
                {
                    listIncomeType.Items.Add(Incomereader.GetString(0));
                }
                Incomereader.Close();
                SqlDataReader Outcomereader = bCommand.ExecuteReader();
                while (Outcomereader.Read())
                {
                    listOutcomeType.Items.Add(Outcomereader.GetString(0));
                }
                Outcomereader.Close();
                aConnection.Close();
            }
            catch
            {              
                return;
            }
        }

        public void FillDeleteItem()
        {
            cmbDeleteItem.Items.Clear();
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select item from [Item] where type='" + cmbTypeDelete.Text.Trim() + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    cmbDeleteItem.Items.Add(reader.GetString(0));
                }
                cmbDeleteItem.Text = cmbDeleteItem.Items[0].ToString();
            }
            catch
            {
                return;
            }       
        }

        private void TypeAdmin_Load(object sender, EventArgs e)
        {
            this.FillList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str1, str2;
            if (cmbTypeAdd.Text == "" || txtAddItem.Text == "")
            {
                MessageBox.Show("所添加的内容为空", "系统错误");
                return;
            }
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select [type],[item] from [Item]";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                SqlDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    str1 = reader.GetString(0);
                    str2 = reader.GetString(1);
                    if (cmbTypeAdd.Text.Trim() == str1.Trim() & txtAddItem.Text.Trim() == str2.Trim())
                    {

                        reader.Close();
                        aConnection.Close();
                        MessageBox.Show("所添加的内容重复", "系统错误");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "insert into [Item]([item],[type]) values('" + txtAddItem.Text + "','" + cmbTypeAdd.Text + "')";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                this.FillList();
                cmbTypeAdd.Text = "";
                txtAddItem.Text = "";
                MessageBox.Show("添加成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "添加失败");
                return;
            }
            this.FillDeleteItem();
        }

        private void cmbTypeDelete_SelectedValueChanged(object sender, EventArgs e)
        {
            this.FillDeleteItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbTypeDelete.Text == "" || cmbDeleteItem.Text == "")
            {
                MessageBox.Show("所删除的内容为空", "系统错误");
                return;
            }
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "delete from [Item] where item='" + cmbDeleteItem.Text + "'and type='" + cmbTypeDelete.Text + "'";
                SqlConnection aConnection = new SqlConnection(connectstring);
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                this.FillList();
                MessageBox.Show("删除成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "删除失败");
                return;
            }
            this.FillDeleteItem();
        }


    }
}
