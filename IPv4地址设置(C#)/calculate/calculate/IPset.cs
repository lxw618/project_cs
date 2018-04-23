using System;
using System.Drawing;
using System.Management;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace calculate
{
    public partial class calc : Form
    {
        Point mouse_offset;

        /// <summary>   
        /// 启用DHCP服务器   
        /// </summary>   
        public static void EnableDHCP()
        {
            ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = wmi.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                //如果没有启用IP设置的网络设备则跳过   
                if (!(bool)mo["IPEnabled"])
                    continue;

                //重置DNS为空   
                mo.InvokeMethod("SetDNSServerSearchOrder", null);
                //开启DHCP   
                mo.InvokeMethod("EnableDHCP", null);
            }
        }
    
        public calc()
        {
            InitializeComponent();
            // 获取本地计算机所有网卡信息
            try
            {
                string carName = "";
                ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT * FROM Win32_NetWorkAdapterConfiguration");
                foreach (ManagementObject sear in search.Get())
                {
                    if (sear["IPAddress"] != null)
                    {
                        carName = sear["Description"].ToString().Trim();
                        cmbAdapter.Items.Add(carName);
                    }
                }
                cmbAdapter.SelectedIndex = 0;
                //GetAddressIP();
                GetState();
                InitChangeText();

            }
            catch
            {
                return;
            }
        }

        void GetState()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection nics = mc.GetInstances();
            foreach (ManagementObject nic in nics)
            {
                if (Convert.ToBoolean(nic["ipEnabled"]) == true)
                {
                    try
                    {
                        if (nic["Description"].ToString() == cmbAdapter.SelectedItem.ToString().Trim())
                        {
                            lblIPState.Text = (nic["IPAddress"] as String[])[0];
                            lblMaskState.Text = (nic["IPSubnet"] as String[])[0];
                            try{
                                lblGatewayState.Text = (nic["DefaultIPGateway"] as String[])[0];
                            }
                            catch
                            {
                                lblGatewayState.Text = "空";
                            }
                        }
                    }
                    catch
                    {
                        ;
                    }
                }
            }
        }

        public static bool IsIPAddress(string ip)
        {
            string[] arr = ip.Split('.');
            if (arr.Length != 4)
                return false;
            string pattern = @"\d{1,3}";
            for (int i = 0; i < arr.Length; i++)
            {
                string d = arr[i];
                if (i == 0 && d == "0")
                    return false;
                if (!Regex.IsMatch(d, pattern))
                    return false;
                if (d != "0")
                {
                    d = d.TrimStart('0');
                    if (d == "")
                        return false;
                    if (int.Parse(d) > 255)
                        return false;
                }
            }
            return true;
        }


        void GetAddressIP()
        {
            ///获取本地的IP地址
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
            lblIPState.Text = AddressIP;
        }

        void InitChangeText()
        {
            string[] subPartIP = lblIPState.Text.Split('.');
            txtIP1.Text =subPartIP[0];
            txtIP2.Text = subPartIP[1];
            txtIP3.Text = subPartIP[2];
            txtIP4.Text = subPartIP[3];
            string[] subPartMask = lblMaskState.Text.Split('.');
            txtMask1.Text = subPartMask[0];
            txtMask2.Text = subPartMask[1];
            txtMask3.Text = subPartMask[2];
            txtMask4.Text = subPartMask[3];
            if (IsIPAddress(lblGatewayState.Text))
            {
                string[] subPartGateway = lblGatewayState.Text.Split('.');
                txtGateway1.Text = subPartGateway[0];
                txtGateway2.Text = subPartGateway[1];
                txtGateway3.Text = subPartGateway[2];
                txtGateway4.Text = subPartGateway[3];
            }
            else if (lblGatewayState.Text == "空")
            {
                txtGateway1.Text = subPartIP[0];
                txtGateway2.Text = subPartIP[1];
                txtGateway3.Text = subPartIP[2];
                txtGateway4.Text = "1";
            }
            else
            {
                txtGateway1.Text = subPartIP[0];
                txtGateway2.Text = subPartIP[1];
                txtGateway3.Text = subPartIP[2];
                txtGateway4.Text = "1";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            this.close.Image = IPset.Properties.Resources.关闭1;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.Image = IPset.Properties.Resources.关闭;
        }

        private void calc_MouseMove(object sender, MouseEventArgs e)
        {
            if (cmbAdapter.Focused)
            {
                mouse_offset = new Point(-e.X, -e.Y);
                lblAdapter.Focus();
            }
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
            if (cmbAdapter.Focused)
            {
                mouse_offset = new Point(-e.X, -e.Y);
                lblAdapter.Focus();
            }
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
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    if (mo["Description"].ToString() == cmbAdapter.SelectedItem.ToString().Trim())
                    { 
                        //开启DHCP   
                        mo.InvokeMethod("EnableDHCP", null);
                        EnableDHCP();
                        MessageBox.Show("已尝试开启DHCP，最终结果以当前状态为准");
                        break;
                    }
                }
            }
            GetState();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    if (mo["Description"].ToString() == cmbAdapter.SelectedItem.ToString().Trim())
                    {
                        ManagementBaseObject newIP = mo.GetMethodParameters("EnableStatic");
                        ManagementBaseObject newGateway = mo.GetMethodParameters("SetGateways");
                        // 将要修改的目标 IP 地址
                        string IPStr = "";
                        IPStr = txtIP1.Text + "." + txtIP2.Text + "." + txtIP3.Text + "." + txtIP4.Text;
                        newIP["IPAddress"] = new string[] { IPStr };

                        //设置子网掩码
                        string subStr = "";
                        subStr = txtMask1.Text + "." + txtMask2.Text + "." + txtMask3.Text + "." + txtMask4.Text;
                        newIP["SubnetMask"] = new string[] { subStr };

                        //设置网关地址 
                        string gatStr = "";
                        gatStr = txtGateway1.Text + "." + txtGateway2.Text + "." + txtGateway3.Text + "." + txtGateway4.Text;
                        newGateway["DefaultIPGateway"] = new string[] { gatStr };         
                        // 修改网络设置
                        try
                        {
                            ManagementBaseObject setIP = mo.InvokeMethod("EnableStatic", newIP,null);
                            ManagementBaseObject setGateways = mo.InvokeMethod("SetGateways", newGateway, null);                            
                            MessageBox.Show("已尝试修改，最终结果以当前状态为准");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    }
                }
            }
            GetState();
        }

        private void cmbAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetState();
        }

        private void txtIP1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIP2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIP3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIP4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMask1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMask2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMask3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMask4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGateway1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGateway2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGateway3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGateway4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (btnDefault.Text == "默认配置")
            {
                txtIP1.Text = "192";
                txtIP2.Text = "168";
                txtIP3.Text = "1";
                txtIP4.Text = "101";
                txtMask1.Text = "255";
                txtMask2.Text = "255";
                txtMask3.Text = "255";
                txtMask4.Text = "0";
                txtGateway1.Text = "192";
                txtGateway2.Text = "168";
                txtGateway3.Text = "1";
                txtGateway4.Text = "1";
                btnDefault.Text = "默认配置1";
            }
            else if (btnDefault.Text == "默认配置1")
            {
                txtIP1.Text = "192";
                txtIP2.Text = "168";
                txtIP3.Text = "3";
                txtIP4.Text = "103";
                txtMask1.Text = "255";
                txtMask2.Text = "255";
                txtMask3.Text = "255";
                txtMask4.Text = "0";
                txtGateway1.Text = "192";
                txtGateway2.Text = "168";
                txtGateway3.Text = "1";
                txtGateway4.Text = "1";
                btnDefault.Text = "默认配置2";
            }
            else if (btnDefault.Text == "默认配置2")
            {
                txtIP1.Text = "192";
                txtIP2.Text = "168";
                txtIP3.Text = "0";
                txtIP4.Text = "101";
                txtMask1.Text = "255";
                txtMask2.Text = "255";
                txtMask3.Text = "255";
                txtMask4.Text = "0";
                txtGateway1.Text = "192";
                txtGateway2.Text = "168";
                txtGateway3.Text = "0";
                txtGateway4.Text = "1";
                btnDefault.Text = "默认配置";
            }


        }

        private void lblAdapter_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                cmbAdapter.Items.Clear();
                string carName = "";
                ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT * FROM Win32_NetWorkAdapterConfiguration");
                foreach (ManagementObject sear in search.Get())
                {
                    if (sear["IPAddress"] != null)
                    {
                        carName = sear["Description"].ToString().Trim();
                        cmbAdapter.Items.Add(carName);
                    }
                }
                cmbAdapter.SelectedIndex = 0;
                GetState();
                timerRefresh.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void lblIP_DoubleClick(object sender, EventArgs e)
        {
           GetAddressIP();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (cmbAdapter.Text == "")
            {
                lblIPState.Text = "127.0.0.1";
                timerRefresh.Enabled = false;
            }
            GetState();
        }                    
   }
}
