namespace calculate
{
    partial class calc
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calc));
            this.title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.lblAdapter = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbAdapter = new System.Windows.Forms.ComboBox();
            this.lblMask = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblStateChange = new System.Windows.Forms.Label();
            this.lblIPState = new System.Windows.Forms.Label();
            this.lblIPChange = new System.Windows.Forms.Label();
            this.lblMaskChange = new System.Windows.Forms.Label();
            this.lblGatewayChange = new System.Windows.Forms.Label();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.lbDot1 = new System.Windows.Forms.Label();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.lblMaskState = new System.Windows.Forms.Label();
            this.lblGatewayState = new System.Windows.Forms.Label();
            this.lbDot2 = new System.Windows.Forms.Label();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.lbDot3 = new System.Windows.Forms.Label();
            this.txtIP3 = new System.Windows.Forms.TextBox();
            this.txtIP4 = new System.Windows.Forms.TextBox();
            this.txtMask4 = new System.Windows.Forms.TextBox();
            this.lbDot6 = new System.Windows.Forms.Label();
            this.txtMask3 = new System.Windows.Forms.TextBox();
            this.lbDot5 = new System.Windows.Forms.Label();
            this.txtMask2 = new System.Windows.Forms.TextBox();
            this.lbDot4 = new System.Windows.Forms.Label();
            this.txtMask1 = new System.Windows.Forms.TextBox();
            this.txtGateway4 = new System.Windows.Forms.TextBox();
            this.lbDot9 = new System.Windows.Forms.Label();
            this.txtGateway3 = new System.Windows.Forms.TextBox();
            this.lbDot8 = new System.Windows.Forms.Label();
            this.txtGateway2 = new System.Windows.Forms.TextBox();
            this.lbDot7 = new System.Windows.Forms.Label();
            this.txtGateway1 = new System.Windows.Forms.TextBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(237, 46);
            this.title.TabIndex = 0;
            this.title.Text = "IPv4地址设置";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // close
            // 
            this.close.Image = global::IPset.Properties.Resources.关闭;
            this.close.Location = new System.Drawing.Point(371, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 42);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 22;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            // 
            // lblAdapter
            // 
            this.lblAdapter.AutoSize = true;
            this.lblAdapter.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdapter.ForeColor = System.Drawing.Color.White;
            this.lblAdapter.Location = new System.Drawing.Point(15, 69);
            this.lblAdapter.Name = "lblAdapter";
            this.lblAdapter.Size = new System.Drawing.Size(92, 27);
            this.lblAdapter.TabIndex = 1;
            this.lblAdapter.Text = "选择网卡";
            this.lblAdapter.DoubleClick += new System.EventHandler(this.lblAdapter_DoubleClick);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(15, 110);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(92, 27);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "当前状态";
            // 
            // cmbAdapter
            // 
            this.cmbAdapter.BackColor = System.Drawing.Color.DarkViolet;
            this.cmbAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAdapter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAdapter.ForeColor = System.Drawing.Color.White;
            this.cmbAdapter.FormattingEnabled = true;
            this.cmbAdapter.ItemHeight = 21;
            this.cmbAdapter.Location = new System.Drawing.Point(124, 68);
            this.cmbAdapter.Name = "cmbAdapter";
            this.cmbAdapter.Size = new System.Drawing.Size(288, 29);
            this.cmbAdapter.TabIndex = 29;
            this.cmbAdapter.SelectedIndexChanged += new System.EventHandler(this.cmbAdapter_SelectedIndexChanged);
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMask.ForeColor = System.Drawing.Color.White;
            this.lblMask.Location = new System.Drawing.Point(39, 181);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(88, 25);
            this.lblMask.TabIndex = 5;
            this.lblMask.Text = "子网掩码";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DarkViolet;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(41, 397);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(107, 30);
            this.btnChange.TabIndex = 26;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 23;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIP.ForeColor = System.Drawing.Color.White;
            this.lblIP.Location = new System.Drawing.Point(39, 150);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(68, 25);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "IP地址";
            this.lblIP.DoubleClick += new System.EventHandler(this.lblIP_DoubleClick);
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGateway.ForeColor = System.Drawing.Color.White;
            this.lblGateway.Location = new System.Drawing.Point(39, 212);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(50, 25);
            this.lblGateway.TabIndex = 6;
            this.lblGateway.Text = "网关";
            // 
            // lblStateChange
            // 
            this.lblStateChange.AutoSize = true;
            this.lblStateChange.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStateChange.ForeColor = System.Drawing.Color.White;
            this.lblStateChange.Location = new System.Drawing.Point(15, 251);
            this.lblStateChange.Name = "lblStateChange";
            this.lblStateChange.Size = new System.Drawing.Size(92, 27);
            this.lblStateChange.TabIndex = 3;
            this.lblStateChange.Text = "状态修改";
            // 
            // lblIPState
            // 
            this.lblIPState.AutoSize = true;
            this.lblIPState.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIPState.ForeColor = System.Drawing.Color.White;
            this.lblIPState.Location = new System.Drawing.Point(155, 150);
            this.lblIPState.Name = "lblIPState";
            this.lblIPState.Size = new System.Drawing.Size(171, 26);
            this.lblIPState.TabIndex = 10;
            this.lblIPState.Text = "255.255.255.255";
            // 
            // lblIPChange
            // 
            this.lblIPChange.AutoSize = true;
            this.lblIPChange.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIPChange.ForeColor = System.Drawing.Color.White;
            this.lblIPChange.Location = new System.Drawing.Point(39, 287);
            this.lblIPChange.Name = "lblIPChange";
            this.lblIPChange.Size = new System.Drawing.Size(68, 25);
            this.lblIPChange.TabIndex = 7;
            this.lblIPChange.Text = "IP地址";
            // 
            // lblMaskChange
            // 
            this.lblMaskChange.AutoSize = true;
            this.lblMaskChange.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaskChange.ForeColor = System.Drawing.Color.White;
            this.lblMaskChange.Location = new System.Drawing.Point(39, 320);
            this.lblMaskChange.Name = "lblMaskChange";
            this.lblMaskChange.Size = new System.Drawing.Size(88, 25);
            this.lblMaskChange.TabIndex = 8;
            this.lblMaskChange.Text = "子网掩码";
            // 
            // lblGatewayChange
            // 
            this.lblGatewayChange.AutoSize = true;
            this.lblGatewayChange.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGatewayChange.ForeColor = System.Drawing.Color.White;
            this.lblGatewayChange.Location = new System.Drawing.Point(39, 352);
            this.lblGatewayChange.Name = "lblGatewayChange";
            this.lblGatewayChange.Size = new System.Drawing.Size(50, 25);
            this.lblGatewayChange.TabIndex = 9;
            this.lblGatewayChange.Text = "网关";
            // 
            // btnDHCP
            // 
            this.btnDHCP.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDHCP.FlatAppearance.BorderSize = 0;
            this.btnDHCP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDHCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnDHCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDHCP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDHCP.ForeColor = System.Drawing.Color.White;
            this.btnDHCP.Location = new System.Drawing.Point(163, 397);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(107, 30);
            this.btnDHCP.TabIndex = 27;
            this.btnDHCP.Text = "开启DHCP";
            this.btnDHCP.UseVisualStyleBackColor = false;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDefault.FlatAppearance.BorderSize = 0;
            this.btnDefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(285, 397);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(107, 30);
            this.btnDefault.TabIndex = 28;
            this.btnDefault.Text = "默认配置";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // lbDot1
            // 
            this.lbDot1.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot1.ForeColor = System.Drawing.Color.White;
            this.lbDot1.Location = new System.Drawing.Point(195, 286);
            this.lbDot1.Name = "lbDot1";
            this.lbDot1.Size = new System.Drawing.Size(21, 26);
            this.lbDot1.TabIndex = 36;
            this.lbDot1.Text = ".";
            // 
            // txtIP1
            // 
            this.txtIP1.BackColor = System.Drawing.Color.DarkViolet;
            this.txtIP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP1.ForeColor = System.Drawing.Color.White;
            this.txtIP1.Location = new System.Drawing.Point(155, 286);
            this.txtIP1.MaxLength = 3;
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIP1.Size = new System.Drawing.Size(50, 26);
            this.txtIP1.TabIndex = 13;
            this.txtIP1.Text = "255";
            this.txtIP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP1_KeyPress);
            // 
            // lblMaskState
            // 
            this.lblMaskState.AutoSize = true;
            this.lblMaskState.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaskState.ForeColor = System.Drawing.Color.White;
            this.lblMaskState.Location = new System.Drawing.Point(155, 181);
            this.lblMaskState.Name = "lblMaskState";
            this.lblMaskState.Size = new System.Drawing.Size(171, 26);
            this.lblMaskState.TabIndex = 11;
            this.lblMaskState.Text = "255.255.255.255";
            // 
            // lblGatewayState
            // 
            this.lblGatewayState.AutoSize = true;
            this.lblGatewayState.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGatewayState.ForeColor = System.Drawing.Color.White;
            this.lblGatewayState.Location = new System.Drawing.Point(155, 212);
            this.lblGatewayState.Name = "lblGatewayState";
            this.lblGatewayState.Size = new System.Drawing.Size(171, 26);
            this.lblGatewayState.TabIndex = 12;
            this.lblGatewayState.Text = "255.255.255.255";
            // 
            // lbDot2
            // 
            this.lbDot2.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot2.ForeColor = System.Drawing.Color.White;
            this.lbDot2.Location = new System.Drawing.Point(251, 286);
            this.lbDot2.Name = "lbDot2";
            this.lbDot2.Size = new System.Drawing.Size(21, 26);
            this.lbDot2.TabIndex = 40;
            this.lbDot2.Text = ".";
            // 
            // txtIP2
            // 
            this.txtIP2.BackColor = System.Drawing.Color.DarkViolet;
            this.txtIP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP2.ForeColor = System.Drawing.Color.White;
            this.txtIP2.Location = new System.Drawing.Point(211, 286);
            this.txtIP2.MaxLength = 3;
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIP2.Size = new System.Drawing.Size(50, 26);
            this.txtIP2.TabIndex = 14;
            this.txtIP2.Text = "255";
            this.txtIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP2_KeyPress);
            // 
            // lbDot3
            // 
            this.lbDot3.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot3.ForeColor = System.Drawing.Color.White;
            this.lbDot3.Location = new System.Drawing.Point(307, 286);
            this.lbDot3.Name = "lbDot3";
            this.lbDot3.Size = new System.Drawing.Size(21, 26);
            this.lbDot3.TabIndex = 42;
            this.lbDot3.Text = ".";
            // 
            // txtIP3
            // 
            this.txtIP3.BackColor = System.Drawing.Color.DarkViolet;
            this.txtIP3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP3.ForeColor = System.Drawing.Color.White;
            this.txtIP3.Location = new System.Drawing.Point(267, 286);
            this.txtIP3.MaxLength = 3;
            this.txtIP3.Name = "txtIP3";
            this.txtIP3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIP3.Size = new System.Drawing.Size(50, 26);
            this.txtIP3.TabIndex = 15;
            this.txtIP3.Text = "255";
            this.txtIP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP3_KeyPress);
            // 
            // txtIP4
            // 
            this.txtIP4.BackColor = System.Drawing.Color.DarkViolet;
            this.txtIP4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP4.ForeColor = System.Drawing.Color.White;
            this.txtIP4.Location = new System.Drawing.Point(323, 286);
            this.txtIP4.MaxLength = 3;
            this.txtIP4.Name = "txtIP4";
            this.txtIP4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIP4.Size = new System.Drawing.Size(40, 26);
            this.txtIP4.TabIndex = 16;
            this.txtIP4.Text = "255";
            this.txtIP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP4_KeyPress);
            // 
            // txtMask4
            // 
            this.txtMask4.BackColor = System.Drawing.Color.DarkViolet;
            this.txtMask4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMask4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMask4.ForeColor = System.Drawing.Color.White;
            this.txtMask4.Location = new System.Drawing.Point(323, 320);
            this.txtMask4.MaxLength = 3;
            this.txtMask4.Name = "txtMask4";
            this.txtMask4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMask4.Size = new System.Drawing.Size(40, 26);
            this.txtMask4.TabIndex = 20;
            this.txtMask4.Text = "255";
            this.txtMask4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMask4_KeyPress);
            // 
            // lbDot6
            // 
            this.lbDot6.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot6.ForeColor = System.Drawing.Color.White;
            this.lbDot6.Location = new System.Drawing.Point(307, 320);
            this.lbDot6.Name = "lbDot6";
            this.lbDot6.Size = new System.Drawing.Size(21, 26);
            this.lbDot6.TabIndex = 49;
            this.lbDot6.Text = ".";
            // 
            // txtMask3
            // 
            this.txtMask3.BackColor = System.Drawing.Color.DarkViolet;
            this.txtMask3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMask3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMask3.ForeColor = System.Drawing.Color.White;
            this.txtMask3.Location = new System.Drawing.Point(267, 320);
            this.txtMask3.MaxLength = 3;
            this.txtMask3.Name = "txtMask3";
            this.txtMask3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMask3.Size = new System.Drawing.Size(50, 26);
            this.txtMask3.TabIndex = 19;
            this.txtMask3.Text = "255";
            this.txtMask3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMask3_KeyPress);
            // 
            // lbDot5
            // 
            this.lbDot5.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot5.ForeColor = System.Drawing.Color.White;
            this.lbDot5.Location = new System.Drawing.Point(251, 320);
            this.lbDot5.Name = "lbDot5";
            this.lbDot5.Size = new System.Drawing.Size(21, 26);
            this.lbDot5.TabIndex = 47;
            this.lbDot5.Text = ".";
            // 
            // txtMask2
            // 
            this.txtMask2.BackColor = System.Drawing.Color.DarkViolet;
            this.txtMask2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMask2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMask2.ForeColor = System.Drawing.Color.White;
            this.txtMask2.Location = new System.Drawing.Point(211, 320);
            this.txtMask2.MaxLength = 3;
            this.txtMask2.Name = "txtMask2";
            this.txtMask2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMask2.Size = new System.Drawing.Size(50, 26);
            this.txtMask2.TabIndex = 18;
            this.txtMask2.Text = "255";
            this.txtMask2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMask2_KeyPress);
            // 
            // lbDot4
            // 
            this.lbDot4.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot4.ForeColor = System.Drawing.Color.White;
            this.lbDot4.Location = new System.Drawing.Point(195, 320);
            this.lbDot4.Name = "lbDot4";
            this.lbDot4.Size = new System.Drawing.Size(21, 26);
            this.lbDot4.TabIndex = 45;
            this.lbDot4.Text = ".";
            // 
            // txtMask1
            // 
            this.txtMask1.BackColor = System.Drawing.Color.DarkViolet;
            this.txtMask1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMask1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMask1.ForeColor = System.Drawing.Color.White;
            this.txtMask1.Location = new System.Drawing.Point(155, 320);
            this.txtMask1.MaxLength = 3;
            this.txtMask1.Name = "txtMask1";
            this.txtMask1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMask1.Size = new System.Drawing.Size(50, 26);
            this.txtMask1.TabIndex = 17;
            this.txtMask1.Text = "255";
            this.txtMask1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMask1_KeyPress);
            // 
            // txtGateway4
            // 
            this.txtGateway4.BackColor = System.Drawing.Color.DarkViolet;
            this.txtGateway4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGateway4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGateway4.ForeColor = System.Drawing.Color.White;
            this.txtGateway4.Location = new System.Drawing.Point(323, 352);
            this.txtGateway4.MaxLength = 3;
            this.txtGateway4.Name = "txtGateway4";
            this.txtGateway4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGateway4.Size = new System.Drawing.Size(40, 26);
            this.txtGateway4.TabIndex = 24;
            this.txtGateway4.Text = "255";
            this.txtGateway4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGateway4_KeyPress);
            // 
            // lbDot9
            // 
            this.lbDot9.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot9.ForeColor = System.Drawing.Color.White;
            this.lbDot9.Location = new System.Drawing.Point(307, 352);
            this.lbDot9.Name = "lbDot9";
            this.lbDot9.Size = new System.Drawing.Size(21, 26);
            this.lbDot9.TabIndex = 56;
            this.lbDot9.Text = ".";
            // 
            // txtGateway3
            // 
            this.txtGateway3.BackColor = System.Drawing.Color.DarkViolet;
            this.txtGateway3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGateway3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGateway3.ForeColor = System.Drawing.Color.White;
            this.txtGateway3.Location = new System.Drawing.Point(267, 352);
            this.txtGateway3.MaxLength = 3;
            this.txtGateway3.Name = "txtGateway3";
            this.txtGateway3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGateway3.Size = new System.Drawing.Size(50, 26);
            this.txtGateway3.TabIndex = 23;
            this.txtGateway3.Text = "255";
            this.txtGateway3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGateway3_KeyPress);
            // 
            // lbDot8
            // 
            this.lbDot8.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot8.ForeColor = System.Drawing.Color.White;
            this.lbDot8.Location = new System.Drawing.Point(251, 352);
            this.lbDot8.Name = "lbDot8";
            this.lbDot8.Size = new System.Drawing.Size(21, 26);
            this.lbDot8.TabIndex = 54;
            this.lbDot8.Text = ".";
            // 
            // txtGateway2
            // 
            this.txtGateway2.BackColor = System.Drawing.Color.DarkViolet;
            this.txtGateway2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGateway2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGateway2.ForeColor = System.Drawing.Color.White;
            this.txtGateway2.Location = new System.Drawing.Point(211, 352);
            this.txtGateway2.MaxLength = 3;
            this.txtGateway2.Name = "txtGateway2";
            this.txtGateway2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGateway2.Size = new System.Drawing.Size(50, 26);
            this.txtGateway2.TabIndex = 22;
            this.txtGateway2.Text = "255";
            this.txtGateway2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGateway2_KeyPress);
            // 
            // lbDot7
            // 
            this.lbDot7.BackColor = System.Drawing.Color.DarkViolet;
            this.lbDot7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDot7.ForeColor = System.Drawing.Color.White;
            this.lbDot7.Location = new System.Drawing.Point(195, 352);
            this.lbDot7.Name = "lbDot7";
            this.lbDot7.Size = new System.Drawing.Size(21, 26);
            this.lbDot7.TabIndex = 52;
            this.lbDot7.Text = ".";
            // 
            // txtGateway1
            // 
            this.txtGateway1.BackColor = System.Drawing.Color.DarkViolet;
            this.txtGateway1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGateway1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGateway1.ForeColor = System.Drawing.Color.White;
            this.txtGateway1.Location = new System.Drawing.Point(155, 352);
            this.txtGateway1.MaxLength = 3;
            this.txtGateway1.Name = "txtGateway1";
            this.txtGateway1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGateway1.Size = new System.Drawing.Size(50, 26);
            this.txtGateway1.TabIndex = 21;
            this.txtGateway1.Text = "255";
            this.txtGateway1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGateway1_KeyPress);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 3000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(3)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(429, 446);
            this.Controls.Add(this.txtGateway4);
            this.Controls.Add(this.lbDot9);
            this.Controls.Add(this.txtGateway3);
            this.Controls.Add(this.lbDot8);
            this.Controls.Add(this.txtGateway2);
            this.Controls.Add(this.lbDot7);
            this.Controls.Add(this.txtGateway1);
            this.Controls.Add(this.txtMask4);
            this.Controls.Add(this.lbDot6);
            this.Controls.Add(this.txtMask3);
            this.Controls.Add(this.lbDot5);
            this.Controls.Add(this.txtMask2);
            this.Controls.Add(this.lbDot4);
            this.Controls.Add(this.txtMask1);
            this.Controls.Add(this.txtIP4);
            this.Controls.Add(this.lbDot3);
            this.Controls.Add(this.txtIP3);
            this.Controls.Add(this.lbDot2);
            this.Controls.Add(this.txtIP2);
            this.Controls.Add(this.lblGatewayState);
            this.Controls.Add(this.lblMaskState);
            this.Controls.Add(this.lbDot1);
            this.Controls.Add(this.txtIP1);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnDHCP);
            this.Controls.Add(this.lblGatewayChange);
            this.Controls.Add(this.lblMaskChange);
            this.Controls.Add(this.lblIPChange);
            this.Controls.Add(this.lblIPState);
            this.Controls.Add(this.lblStateChange);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.cmbAdapter);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAdapter);
            this.Controls.Add(this.close);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPv4地址设置";
            this.Load += new System.EventHandler(this.calc_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calc_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.calc_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label lblAdapter;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbAdapter;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblStateChange;
        private System.Windows.Forms.Label lblIPState;
        private System.Windows.Forms.Label lblIPChange;
        private System.Windows.Forms.Label lblMaskChange;
        private System.Windows.Forms.Label lblGatewayChange;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label lbDot1;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.Label lblMaskState;
        private System.Windows.Forms.Label lblGatewayState;
        private System.Windows.Forms.Label lbDot2;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.Label lbDot3;
        private System.Windows.Forms.TextBox txtIP3;
        private System.Windows.Forms.TextBox txtIP4;
        private System.Windows.Forms.TextBox txtMask4;
        private System.Windows.Forms.Label lbDot6;
        private System.Windows.Forms.TextBox txtMask3;
        private System.Windows.Forms.Label lbDot5;
        private System.Windows.Forms.TextBox txtMask2;
        private System.Windows.Forms.Label lbDot4;
        private System.Windows.Forms.TextBox txtMask1;
        private System.Windows.Forms.TextBox txtGateway4;
        private System.Windows.Forms.Label lbDot9;
        private System.Windows.Forms.TextBox txtGateway3;
        private System.Windows.Forms.Label lbDot8;
        private System.Windows.Forms.TextBox txtGateway2;
        private System.Windows.Forms.Label lbDot7;
        private System.Windows.Forms.TextBox txtGateway1;
        private System.Windows.Forms.Timer timerRefresh;
    }
}

