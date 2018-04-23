using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace calculate
{
    public partial class calc : Form
    {
        Point mouse_offset;
        Thread t;
        public bool bolNum(string temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                byte tempByte = Convert.ToByte(temp[i]);
                if ((tempByte < 48) || (tempByte > 57))
                    return false;
            }
            return true;
        }

        public Boolean TcpConnect(string IP, int port)
        {
            TcpClient t = new TcpClient();
            try
            {
                t.Connect(IP, port);
                if (t.Connected)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                t.Close();
            }
        }

    
        public calc()
        {
            InitializeComponent();
        }



        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            this.close.Image = scaner.Properties.Resources.关闭1;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.Image = scaner.Properties.Resources.关闭;
        }

        private void calc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void calc_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
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

        private void calc_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.txtPortStart.ShortcutsEnabled = false;
            this.txtPortEnd.ShortcutsEnabled = false;
        }

        public void ThreadProc()
        {
            int i;
            string IP=cmbAddress.Text;
            int portStart = Int32.Parse(txtPortStart.Text);
            int portEnd = Int32.Parse(txtPortEnd.Text);
            
            for (i = portStart; i <= portEnd; i++)
            {
               
                    if (TcpConnect(IP, i))
                    {
                        this.listResult.Items.Add(i.ToString() + "端口开放");
                        this.listResult.TopIndex = this.listResult.Items.Count - 1;
                    }
                    else
                    {
                        this.listResult.Items.Add(i.ToString() + "端口关闭");
                        this.listResult.TopIndex = this.listResult.Items.Count - 1;
                    }
            }
            cmbAddress.Enabled = true;
            txtPortStart.Enabled = true;
            txtPortEnd.Enabled = true;
            this.btnScaner.Enabled = true;
            btnScaner.Text = "开始扫描";
            
        }

        public void btnScaner_Click(object sender, EventArgs e)
        {
            if (cmbAddress.Text == "")
            {
                cmbAddress.Text = "localhost";
            }
            if (txtPortStart.Text == "")
            {
                txtPortStart.Text = "445";
            }
            if (txtPortEnd.Text == "")
            {
                txtPortEnd.Text = "445";
            }
            try
            {
                if (Int32.Parse(txtPortStart.Text) > 65535 || Int32.Parse(txtPortEnd.Text) > 65535)
                {
                    MessageBox.Show("端口号应小于65536");
                    return;
                }
            
                if(Int32.Parse(txtPortStart.Text)>Int32.Parse(txtPortEnd.Text))
                {
                    MessageBox.Show("前一个数应小于后一个数");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("字符串输入格式不正确，请重新输入");
                return;
            }
            if (btnScaner.Text == "开始扫描")
            {
                listResult.Items.Clear();
                cmbAddress.Enabled = false;
                txtPortStart.Enabled = false;
                txtPortEnd.Enabled = false;
                t = new Thread(new ThreadStart(ThreadProc));
                t.IsBackground = true;
                t.Start();
                btnScaner.Text = "停止扫描";
            }
            else
            {              
                cmbAddress.Enabled = true;
                txtPortStart.Enabled =true;
                txtPortEnd.Enabled = true;
                t.Abort();
                btnScaner.Text = "开始扫描";
            }
            
        }

        private void txtPortStart_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPortEnd_KeyPress(object sender, KeyPressEventArgs e)
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
