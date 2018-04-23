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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calc));
            this.title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPortRange = new System.Windows.Forms.Label();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.txtPortStart = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtPortEnd = new System.Windows.Forms.TextBox();
            this.listResult = new System.Windows.Forms.ListBox();
            this.btnScaner = new System.Windows.Forms.Button();
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
            this.title.Size = new System.Drawing.Size(160, 46);
            this.title.TabIndex = 1;
            this.title.Text = "端口扫描";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // close
            // 
            this.close.Image = global::scaner.Properties.Resources.关闭;
            this.close.Location = new System.Drawing.Point(361, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 42);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 22;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(16, 76);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(96, 28);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "主机地址";
            // 
            // lblPortRange
            // 
            this.lblPortRange.AutoSize = true;
            this.lblPortRange.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPortRange.ForeColor = System.Drawing.Color.White;
            this.lblPortRange.Location = new System.Drawing.Point(16, 127);
            this.lblPortRange.Name = "lblPortRange";
            this.lblPortRange.Size = new System.Drawing.Size(96, 28);
            this.lblPortRange.TabIndex = 4;
            this.lblPortRange.Text = "端口范围";
            // 
            // cmbAddress
            // 
            this.cmbAddress.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Items.AddRange(new object[] {
            "localhost",
            "baidu.com",
            "qq.com",
            "192.168.1.1",
            "192.168.0.1",
            "127.0.0.1"});
            this.cmbAddress.Location = new System.Drawing.Point(142, 76);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(260, 33);
            this.cmbAddress.TabIndex = 3;
            this.cmbAddress.Text = "localhost";
            // 
            // txtPortStart
            // 
            this.txtPortStart.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPortStart.Location = new System.Drawing.Point(142, 125);
            this.txtPortStart.MaxLength = 5;
            this.txtPortStart.Name = "txtPortStart";
            this.txtPortStart.Size = new System.Drawing.Size(95, 33);
            this.txtPortStart.TabIndex = 5;
            this.txtPortStart.Text = "0";
            this.txtPortStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortStart_KeyPress);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(252, 127);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 28);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "到";
            // 
            // txtPortEnd
            // 
            this.txtPortEnd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPortEnd.Location = new System.Drawing.Point(302, 126);
            this.txtPortEnd.MaxLength = 5;
            this.txtPortEnd.Name = "txtPortEnd";
            this.txtPortEnd.Size = new System.Drawing.Size(100, 33);
            this.txtPortEnd.TabIndex = 7;
            this.txtPortEnd.Text = "65535";
            this.txtPortEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortEnd_KeyPress);
            // 
            // listResult
            // 
            this.listResult.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 25;
            this.listResult.Location = new System.Drawing.Point(20, 176);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(382, 154);
            this.listResult.TabIndex = 0;
            // 
            // btnScaner
            // 
            this.btnScaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btnScaner.FlatAppearance.BorderSize = 0;
            this.btnScaner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnScaner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btnScaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScaner.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScaner.ForeColor = System.Drawing.Color.White;
            this.btnScaner.Location = new System.Drawing.Point(165, 344);
            this.btnScaner.Name = "btnScaner";
            this.btnScaner.Size = new System.Drawing.Size(101, 30);
            this.btnScaner.TabIndex = 8;
            this.btnScaner.Text = "开始扫描";
            this.btnScaner.UseVisualStyleBackColor = false;
            this.btnScaner.Click += new System.EventHandler(this.btnScaner_Click);
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(422, 386);
            this.Controls.Add(this.btnScaner);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.txtPortEnd);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtPortStart);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.lblPortRange);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.close);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "端口扫描";
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
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPortRange;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.TextBox txtPortStart;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtPortEnd;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button btnScaner;
    }
}

