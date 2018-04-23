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
    public partial class ExchangeRate : Form
    {
        Point mouse_offset;
        public static ExchangeRate fER = null;
        double dbleCNY;
        double dbleEUR;
        double dbleGBP;
        double dbleAUD;
        double dbleJPY;
        public ExchangeRate()
        {
            InitializeComponent();
            fER = this;
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
                dbleCNY = Convert.ToDouble(reader.GetValue(1));
                dbleEUR = Convert.ToDouble(reader.GetValue(2));
                dbleGBP = Convert.ToDouble(reader.GetValue(3));
                dbleAUD = Convert.ToDouble(reader.GetValue(4));
                dbleJPY = Convert.ToDouble(reader.GetValue(5));
                reader.Close();
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        public double OtherToUSD()
        {
            try
            {
                if (cmbOriginal.Text == "人民币CNY")
                {
                    return Convert.ToDouble(txtOriginal.Text) / dbleCNY;
                }
                else if (cmbOriginal.Text == "欧元EUR")
                {
                    return Convert.ToDouble(txtOriginal.Text) / dbleEUR;
                }
                else if (cmbOriginal.Text == "英镑GBP")
                {
                    return Convert.ToDouble(txtOriginal.Text) / dbleGBP;
                }
                else if (cmbOriginal.Text == "澳元AUD")
                {
                    return Convert.ToDouble(txtOriginal.Text) / dbleAUD;
                }
                else if (cmbOriginal.Text == "日元JPY")
                {
                    return Convert.ToDouble(txtOriginal.Text) / dbleJPY;
                }
                else
                {
                    return Convert.ToDouble(txtOriginal.Text);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "错误");
                return 0;
            }
        }

        public double USDToOther(double dbleUSDAfter)
        {
            try
            {
                if (cmbAfter.Text == "人民币CNY")
                {
                    return dbleUSDAfter * dbleCNY;
                }
                else if (cmbAfter.Text == "欧元EUR")
                {
                    return dbleUSDAfter * dbleEUR;
                }
                else if (cmbAfter.Text == "英镑GBP")
                {
                    return dbleUSDAfter * dbleGBP;
                }
                else if (cmbAfter.Text == "澳元AUD")
                {
                    return dbleUSDAfter * dbleAUD;
                }
                else if (cmbAfter.Text == "日元JPY")
                {
                    return dbleUSDAfter * dbleJPY;
                }
                else
                {
                    return dbleUSDAfter;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "错误");
                return 0;
            }
        }

        private void ExchangeRate_Load(object sender, EventArgs e)
        {
            this.LoadRate();
            cmbOriginal.Text = "人民币CNY";
            cmbAfter.Text = "美元USD";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (ExchangeRateSet.fERS != null)
            {
                ExchangeRateSet.fERS.Close();
                ExchangeRateSet.fERS = null;
            }
            this.Close();
            fER = null;
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            picClose.Image = Properties.Resources.Close2;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.Close1;
        }

        private void ExchangeRate_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void ExchangeRate_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void txtOriginal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (txtOriginal.Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else if (txtOriginal.Text == "" && e.KeyChar == '.')
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

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (ExchangeRateSet.fERS == null)
            {
                ExchangeRateSet frmExchangeRateSet = new ExchangeRateSet();
                frmExchangeRateSet.Show();

            }
            else
            {
                ExchangeRateSet.fERS.Activate();
            }
        }

        private void txtAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (txtOriginal.Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else if (txtOriginal.Text == "" && e.KeyChar == '.')
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

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (txtOriginal.Text == "" || cmbOriginal.Text == "" || cmbAfter.Text == "")
            {
                MessageBox.Show("请将金额和货币类型填写完整", "填写错误");
                return;
            }
            if(cmbOriginal.Text==cmbAfter.Text)
            {
                txtAfter.Text = txtOriginal.Text;
                return;
            }
            double USD=this.OtherToUSD();
            txtAfter.Text=this.USDToOther(USD).ToString();
        }
    }
}
