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
    public partial class ProgramSet : Form
    {
        public ProgramSet()
        {
            InitializeComponent();
        }

        private void ProgramSet_Load(object sender, EventArgs e)
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
                cmbTool.Text = reader.GetString(7);
                cmbStatus.Text = reader.GetString(8);
                cmbBackground.Text = reader.GetString(9);
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
                string connectstring = "provider=Microsoft.jet.OLEDB.4.0;Data Source=accountsystem.mdb;Jet OleDb:Database Password=lxw618";
                string sqlcommand = "update [Set] set [toolbar]='" + cmbTool.Text + "',[statusbar]='" + cmbStatus.Text + "',[background]='" + cmbBackground.Text + "'";
                OleDbConnection aConnection = new OleDbConnection(connectstring);
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(sqlcommand, aConnection);
                aCommand.ExecuteNonQuery();              
                MessageBox.Show("保存成功", "恭喜");
                aConnection.Close();
                frmMain.f1.LoadSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统错误");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbTool.Text == "显示")
            {
                frmMain.f1.toolStripOption.Visible = true;
            }
            else
            {
                frmMain.f1.toolStripOption.Visible = false;
            }
            if (cmbStatus.Text == "显示")
            {
                frmMain.f1.statusStripMain.Visible = true;
            }
            else
            {
                frmMain.f1.statusStripMain.Visible = false;
            }
            if (cmbBackground.Text == "默认")
            {
                frmMain.f1.BackgroundImage = Properties.Resources.MainBackImage;
            }
            else if (cmbBackground.Text == "粉红爱心")
            {
                frmMain.f1.BackgroundImage = Properties.Resources.MainBackground1;
            }
            else if (cmbBackground.Text == "蓝色小星星")
            {
                frmMain.f1.BackgroundImage = Properties.Resources.MainBackground2;
            }
            else
            {
                frmMain.f1.BackgroundImage = Properties.Resources.MainBackImage;
            }
        }
    }
}
