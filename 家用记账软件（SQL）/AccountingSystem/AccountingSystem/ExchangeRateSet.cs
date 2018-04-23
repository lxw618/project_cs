using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccountingSystem
{   
    public partial class ExchangeRateSet : Form
    {
        public static ExchangeRateSet fERS = null;
        Point mouse_offset;
        public ExchangeRateSet()
        {
            InitializeComponent();
            fERS = this;
        }

        public void LoadRate()
        {
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string acommand = "select * from [ExchangeRateSet]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(acommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                if (cmbAfter.Text == "人民币CNY")
                {
                    txtAfter.Text = reader.GetValue(1).ToString();
                }
                else if(cmbAfter.Text == "欧元EUR")
                {
                    txtAfter.Text = reader.GetValue(2).ToString();
                }
                else if (cmbAfter.Text == "英镑GBP")
                {
                    txtAfter.Text = reader.GetValue(3).ToString();
                }
                else if (cmbAfter.Text == "澳元AUD")
                {
                    txtAfter.Text = reader.GetValue(4).ToString();
                }
                else if (cmbAfter.Text == "日元JPY")
                {
                    txtAfter.Text = reader.GetValue(5).ToString();
                }
                else
                {
                    return;
                }
                reader.Close();
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
            fERS = null;
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            picClose.Image = Properties.Resources.Close2;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.Close1;
        }

        private void ExchangeRateSet_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void ExchangeRateSet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void ExchangeRateSet_Load(object sender, EventArgs e)
        {
            cmbAfter.Text = "人民币CNY";
            this.LoadRate();
        }

        private void cmbAfter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadRate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAfter.Text== "")
            {
                MessageBox.Show("汇率不能为空", "输入错误");
                return;
            }
            try
            {
                string strType;
                if (cmbAfter.Text == "人民币CNY")
                {
                    strType = "CNY";
                }
                else if (cmbAfter.Text == "欧元EUR")
                {
                    strType = "EUR";
                }
                else if (cmbAfter.Text == "英镑GBP")
                {
                    strType = "GBP";
                }
                else if (cmbAfter.Text == "澳元AUD")
                {
                    strType = "AUD";
                }
                else if (cmbAfter.Text == "日元JPY")
                {
                    strType = "JPY";
                }
                else
                {
                    return;
                }
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "update [ExchangeRateSet] set ["+strType+"]='" + txtAfter.Text + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                MessageBox.Show("保存成功", "恭喜");
                aConnection.Close();
                this.Close();
                fERS = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void txtAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (txtAfter.Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else if (txtAfter.Text == "" && e.KeyChar == '.')
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
