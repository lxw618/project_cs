using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccountSystem
{
    public partial class MainForm : Form
    {
        public static MainForm f1 = null;
        public MainForm()
        {
            InitializeComponent();
            f1 = this;
        }

        private void MenuItemCalc_Click(object sender, EventArgs e)
        {
            {
                
                calculate.calc f = new calculate.calc();
                f.Show();
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            string nickname;
            string username = (string)this.Tag;
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select nickname from [User] where username='" + username+"'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                nickname = reader.GetString(0);
                reader.Close();
                aConnection.Close();
                this.Text = this.Text + "-" + nickname;           
            }
            catch { }
            string accountstyle;
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select accountstyle from [User] where username='" + username + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                accountstyle = reader.GetString(0);
                reader.Close();
                aConnection.Close();
                if (accountstyle != "管理员")
                {
                    MenuItemDeleteUser.Visible = false;
                }
            }
            catch
            {
                return;
            }
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

        private void MenuItemChangeUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Loading.f0.Show();
        }

        private void MenuItemAddAccount_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "AddAccount")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            AddAccount f = new AddAccount();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemChangeInformation_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "ChangeAccountInfo")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            ChangeAccountInfo f = new ChangeAccountInfo();
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

        private void MenuItemDayInstance_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "DayInstance")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            DayInstance f = new DayInstance();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemMonthInstance_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "MonthInstance")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            MonthInstance f = new MonthInstance();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemFamilyInstance_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "FamilyInstance")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            FamilyInstance f = new FamilyInstance();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemCalendar_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "Calendar")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            Calendar f = new Calendar();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemUseHelp_Click(object sender, EventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "UseAbout")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    return;
                }
            }
            UseAbout f = new UseAbout();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuItemAppCaption_Click(object sender, EventArgs e)
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

    }
}
