using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;

namespace AccountingSystem
{
    public partial class SendEmail : Form
    {
        public static SendEmail fSM = null;
        Point mouse_offset;
        string strServer;
        string strPort;
        string strAddress;
        string strUsername;
        string strPassword;
        public SendEmail()
        {
            InitializeComponent();
            fSM = this;
        }

        public Boolean IsNull()
        {
            if (txtRecipent.Text == "" || txtContent.Text == "")
            {
                MessageBox.Show("收件人、文本内容不能为空", "提示");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SendEmail_Load(object sender, EventArgs e)
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
                strServer = reader.GetString(1);
                strPort = reader.GetString(2);
                strAddress = reader.GetString(3);
                strUsername = reader.GetString(4);
                strPassword = reader.GetString(5);
                reader.Close();
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {            
            if (SendEmailSet.fSMS != null)
            {
                SendEmailSet.fSMS.Close();
                SendEmailSet.fSMS = null;
                
            }
            this.Close();
            fSM = null;           
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            picClose.Image = Properties.Resources.Close2;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.Close1;
        }

        private void SendEmail_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void SendEmail_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (SendEmailSet.fSMS == null)
            {
                SendEmailSet frmSendEmailSet = new SendEmailSet();
                frmSendEmailSet.Show();

            }
            else
            {
                SendEmailSet.fSMS.Activate();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsNull() == true)
                {
                    return;
                }
                MailMessage m = new MailMessage();
                SmtpClient c = new SmtpClient(strServer, Convert.ToInt32(strPort));
                MailAddress fr = new MailAddress(strAddress);
                c.Credentials = new NetworkCredential(strUsername, strPassword);
                m.From = fr;
                m.Body = txtContent.Text;
                m.To.Add(txtRecipent.Text);
                m.Subject = txtTheme.Text;
                if (txtCopy .Text!= "")
                {
                    m.CC.Add(txtCopy.Text);
                }
                c.Send(m);
                txtTheme.Text = "";
                txtContent.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "发送失败");
                return;
            }
            MessageBox.Show("发送成功");
        }
    }
}
