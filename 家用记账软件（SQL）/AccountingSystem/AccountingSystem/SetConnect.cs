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
    public partial class SetConnect : Form
    {
        Point mouse_offset;
        public static SetConnect fSC = null;
        public SetConnect()
        {
            InitializeComponent();
            fSC = this;
        }

        public Boolean IsNull()
        {
            if (txtServer.Text == "" || txtDatabase.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("服务器名、数据库名、用户名、密码不能为空", "提示");
                return true;
            }
            else
            {                
                return false;
            }
        }

        private void btnSetConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsNull() == true)
                {
                    return;
                }                
                string connectstring = "Data Source=" + txtServer.Text + "\\" + txtCase.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text;
                string sqlcommand = "select username,password from [User]";
                SqlConnection sqlConnection = new SqlConnection(connectstring);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                MessageBox.Show("连接成功", "恭喜");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }   
        }

        private void SetConnect_Load(object sender, EventArgs e)
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
                txtServer.Text = reader.GetString(2);
                txtCase.Text = reader.GetString(3);
                txtDatabase.Text = reader.GetString(4);
                txtUsername.Text = reader.GetString(5);
                txtPassword.Text = reader.GetString(6);
                reader.Close();
                aConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void btnSaveConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsNull() == true)
                {
                    return;
                }
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "update [Set] set [connect]='Data Source=" + txtServer.Text + "\\" + txtCase.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text + "'";
                string sqlcommand2 = "update [Set] set [server]='" + txtServer.Text + "',[case]='" + txtCase.Text + "',[database]='" + txtDatabase.Text + "',[user]='" + txtUsername.Text + "',[password]='" + txtPassword.Text + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();
                OleDbCommand aCommand2 = new OleDbCommand(sqlcommand2, aConnection);
                aCommand2.ExecuteNonQuery();
                MessageBox.Show("保存成功", "恭喜");
                aConnection.Close();
                this.Close();
                fSC = null;
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
            this.Close();
            fSC = null;
        }

        private void SetConnect_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void SetConnect_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }


    }
}
