using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;

namespace AccountingSystem
{
    public partial class SendEmailSet : Form
    {
        Point mouse_offset;
        public static SendEmailSet fSMS = null;
        public SendEmailSet()
        {
            InitializeComponent();
            fSMS = this;
        }

        public Boolean IsNull()
        {
            if (txtServer.Text == "" || txtPort.Text == "" || txtAddress.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("服务器名、端口号、发送邮箱、用户名、密码不能为空", "提示");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            picClose.Image = Properties.Resources.Close2;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.Close1;
        }

        private void SendEmailSet_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void SendEmailSet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void SendEmailSet_Load(object sender, EventArgs e)
        {
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string acommand = "select * from [EmailSet]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(acommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                txtServer.Text = reader.GetString(1);
                txtPort.Text = reader.GetString(2);
                txtAddress.Text = reader.GetString(3);
                txtUsername.Text = reader.GetString(4);
                txtPassword.Text = reader.GetString(5);
                reader.Close();
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsNull() == true)
                {
                    return;
                }
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";              
                string sqlcommand = "update [EmailSet] set [server]='" + txtServer.Text + "',[port]='" + txtPort.Text + "',[sendaddress]='" + txtAddress.Text + "',[username]='" + txtUsername.Text + "',[password]='" + txtPassword.Text + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();                
                MessageBox.Show("保存成功", "恭喜");
                aConnection.Close();
                this.Close();
                fSMS = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
            fSMS = null; 
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsNull() == true)
                {
                    return;
                }
                MailMessage m = new MailMessage();
                SmtpClient c = new SmtpClient(txtServer.Text, Convert.ToInt32(txtPort.Text));
                MailAddress fr = new MailAddress(txtAddress.Text);
                c.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                m.From = fr;
                m.Subject = "软件测试邮件";
                m.Body = "测试邮件";
                m.To.Add("lxw618@163.com");
                c.Send(m);
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "测试失败");
                return;
            }
            MessageBox.Show("测试成功");
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
