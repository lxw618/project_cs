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
    public partial class Loading : Form
    {
        Point mouse_offset;
        public static Loading f0 = null; 
        public Loading()
        {
            InitializeComponent();
            f0 = this;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            this.close.Image = this.closered.Image;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.Image = this.closetransp.Image;
        }


        private void Loading_MouseDown(object sender, MouseEventArgs e)
        {

            mouse_offset = new Point(-e.X, -e.Y);
        }


        private void Loading_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }



        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                Point titleLoc = title.Location;
                mousePos.Offset(mouse_offset.X - titleLoc.X, mouse_offset.Y - titleLoc.Y);
                Location = mousePos;
            }
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }



        private void clear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void logon_Click(object sender, EventArgs e)
        {
            string str1, str2;
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select username,password from [User]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand,aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    str1 = reader.GetString(0);
                    str2 = reader.GetString(1);
                    if (txtUsername.Text.Trim() == str1.Trim() && txtPassword.Text.Trim() == str2.Trim())
                    {
                        
                        reader.Close();
                        aConnection.Close();
                        MainForm a = new MainForm();
                        a.Tag = str1.Trim();
                        a.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("登录失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.logon_Click(sender, e); 
                e.Handled=true;
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

    }
}

    
