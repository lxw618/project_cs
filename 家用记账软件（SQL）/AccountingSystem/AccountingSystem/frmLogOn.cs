using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace AccountingSystem
{
    public partial class frmLogOn : Form
    {
        Point mouse_offset;
        public string sqlConectstring;
        public static frmLogOn f0 = null; 
        public frmLogOn()
        {
            InitializeComponent();
            f0 = this;           
        }

        public void ClearPassword()
        {
            txtPassword.Text = "";
        }

        public Boolean GetSqlConnectString()
        {
            try
            {
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "select connect from [Set]";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                OleDbDataReader reader = aCommand.ExecuteReader();
                reader.Read();
                sqlConectstring = reader.GetString(0);               
                reader.Close();
                aConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");                
                return false;
            }
        }

        private void frmLogOn_Load(object sender, EventArgs e)
        {          
            txtUsername.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            if (this.GetSqlConnectString() == false)
            {
                return;
            }
            string strUsername, strPassword;
            try
            {
                string connectstring = sqlConectstring;
                string sqlcommand = "select username,password from [User]";
                SqlConnection sqlConnection = new SqlConnection(connectstring);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    strUsername = reader.GetString(0);
                    strPassword = reader.GetString(1);
                    if (txtUsername.Text.Trim() == strUsername.Trim() && txtPassword.Text.Trim() == strPassword.Trim())
                    {

                        reader.Close();
                        sqlConnection.Close();
                        frmMain MainWindow = new frmMain();
                        MainWindow.Tag = strUsername.Trim();
                        MainWindow.Show();
                        this.Hide();
                        if (SetConnect.fSC!=null)
                        {
                            SetConnect.fSC.Close();
                        }
                        return;
                    }
                }
                MessageBox.Show("用户名或密码错误，登录失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
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

        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogOn_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void frmLogOn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
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
                this.btnLogOn_Click(sender, e);
                e.Handled = true;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (SetConnect.fSC== null)
            {
                SetConnect setconnect = new SetConnect();
                setconnect.Show();

            }
            else
            {
                SetConnect.fSC.Activate();
            }            
        }


   
    }
}
