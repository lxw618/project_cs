using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace AccountingSystem
{
    public partial class frmMain : Form
    {
        public static frmMain f1 = null;
        Calculator frmcalc = new Calculator();
        public frmMain()
        {
            InitializeComponent();
            f1 = this;
        }

        public void LoadSet()
        {
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string acommand = "select * from [Set]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(acommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                string strTool = reader.GetString(7);
                string strStatus = reader.GetString(8);
                string strBackground = reader.GetString(9);
                if (strTool == "显示")
                {
                    this.toolStripOption.Visible = true;
                }
                else
                {
                    this.toolStripOption.Visible = false; 
                }
                if (strStatus == "显示")
                {
                    this.statusStripMain.Visible = true;
                }
                else
                {
                    this.statusStripMain.Visible = false;
                }
                if (strBackground== "默认")
                {
                    this.BackgroundImage = Properties.Resources.MainBackImage;
                }
                else if (strBackground == "粉红爱心")
                {
                    this.BackgroundImage = Properties.Resources.MainBackground1;
                }
                else if (strBackground == "蓝色小星星")
                {
                    this.BackgroundImage = Properties.Resources.MainBackground2;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.MainBackImage;
                }
                reader.Close();
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "设置异常");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认是否退出系统？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {               
                Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemChangeUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if (ExchangeRate.fER != null)
            {
                ExchangeRate.fER.Close();
                ExchangeRate.fER = null;
            }
            if (ExchangeRateSet.fERS != null)
            {
                ExchangeRateSet.fERS.Close();
                ExchangeRateSet.fERS = null;
            }
            if (SendEmail.fSM != null)
            {
                SendEmail.fSM.Close();
                SendEmail.fSM = null;
            }
            if (SendEmailSet.fSMS != null)
            {
                SendEmailSet.fSMS.Close();
                SendEmailSet.fSMS = null;
            }
            if (frmcalc.IsDisposed == false)
            {
                frmcalc.Close();
            }
            frmLogOn.f0.Show();
            frmLogOn.f0.ClearPassword();
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemAddRecord_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "AddRecord")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            AddRecord f = new AddRecord();
            f.MdiParent = this;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string nickname;
            string username = (string)this.Tag;
            try
            {
                string connectstring = frmLogOn.f0.sqlConectstring;
                string sqlcommand = "select nickname from [User] where username='" + username + "'";
                SqlConnection sqlConnection = new SqlConnection(connectstring);
                sqlConnection.Open();
                SqlCommand sqlReadCommand = new SqlCommand(sqlcommand, sqlConnection);
                SqlDataReader reader = sqlReadCommand.ExecuteReader();
                reader.Read();
                nickname = reader.GetString(0);
                reader.Close();
                sqlConnection.Close();
                this.Text = this.Text + "-" + nickname;
                this.toolStripStatusCurrentUser.Text = "当前用户：" + nickname;
            }
            catch
            {
                this.Text = "家庭记账软件";
            }
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
                    MenuItemDeleteUser.Visible = false;
                    MenuItemAddUser.Visible = false;                    
                }
                else if (accountstyle == "管理员")
                {
                    MenuItemDeleteUser.Enabled = true;
                    MenuItemAddUser.Enabled = true;                    
                }
            }
            catch
            {
                return;
            }
            this.LoadSet();
        }

        private void StripButtonSwitchUser_Click(object sender, EventArgs e)
        {
            this.MenuItemChangeUser_Click(sender, e);
        }

        private void MenuItemDeleteRecord_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "DeleteRecord")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            DeleteRecord f = new DeleteRecord();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemChangeRecord_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "ChangeRecord")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            ChangeRecord f = new ChangeRecord();
            f.MdiParent = this;
            f.Show();
        
        }

        private void MenuItemAddUser_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "AddUser")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            AddUser f = new AddUser();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemDeleteUser_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "DeleteUser")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            DeleteUser f = new DeleteUser();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemChangeUserInformation_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "ChangeUserInformation")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            ChangeUserInformation f = new ChangeUserInformation();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemTypeAdmin_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "TypeAdmin")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            TypeAdmin f = new TypeAdmin();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemChangePassword_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "ChangePassword")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            ChangePassword f = new ChangePassword();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemEveryDayCase_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "EveryDayCase")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            EveryDayCase f = new EveryDayCase();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemEveryMonthCase_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "EveryMonthCase")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            EveryMonthCase f = new EveryMonthCase();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemEveryYearCase_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "EveryYearCase")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            EveryYearCase f = new EveryYearCase();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemTypeCase_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "TypeCase")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            TypeCase f = new TypeCase();
            f.MdiParent = this;
            f.Show();
        }

        private void StripButtonCalc_Click(object sender, EventArgs e)
        {

            if (frmcalc.IsDisposed)
            {
                frmcalc = new Calculator();
            }
            frmcalc.Show();
            frmcalc.Activate();

        }

        private void MenuItemCalc_Click(object sender, EventArgs e)
        {
            if (frmcalc.IsDisposed)
            {
                frmcalc = new Calculator();
            }
            frmcalc.Show();
            frmcalc.Activate();
        }

        private void StripButtonCalendar_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.MdiParent = this;
            calendar.Show();
        }

        private void MenuItemCalendar_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.MdiParent = this;
            calendar.Show();
        }

        private void StripButtonAbout_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "ProgramAbout")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            ProgramAbout f = new ProgramAbout();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemAboutProgram_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "ProgramAbout")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            ProgramAbout f = new ProgramAbout();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemSettings_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "ProgramSet")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            ProgramSet f = new ProgramSet();
            f.MdiParent = this;
            f.Show();
        }

        private void StripButtonSet_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "ProgramSet")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            ProgramSet f = new ProgramSet();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemMail_Click(object sender, EventArgs e)
        {
            if (SendEmail.fSM == null)
            {
                SendEmail frmSendEmail = new SendEmail();
                frmSendEmail.Show();

            }
            else
            {
                SendEmail.fSM.Activate();
            }
        }

        private void MenuItemExchangeRate_Click(object sender, EventArgs e)
        {
            if (ExchangeRate.fER == null)
            {
                ExchangeRate frmExchangeRate = new ExchangeRate();
                frmExchangeRate.Show();

            }
            else
            {
                ExchangeRate.fER.Activate();
            }
        }

        private void StripButtonAddRecord_Click(object sender, EventArgs e)
        {
            MenuItemAddRecord_Click(sender, e);
        }
    }
}
