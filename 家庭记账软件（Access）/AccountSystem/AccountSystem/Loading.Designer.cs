namespace AccountSystem
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.title = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.logon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.closered = new System.Windows.Forms.PictureBox();
            this.closetransp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closetransp)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(135, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(210, 42);
            this.title.TabIndex = 0;
            this.title.Text = "家庭记账软件";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUsername.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtUsername.Location = new System.Drawing.Point(152, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(183, 33);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(152, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(183, 33);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(152, 224);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(72, 33);
            this.clear.TabIndex = 3;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // logon
            // 
            this.logon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.logon.FlatAppearance.BorderSize = 0;
            this.logon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logon.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logon.ForeColor = System.Drawing.Color.White;
            this.logon.Location = new System.Drawing.Point(260, 224);
            this.logon.Name = "logon";
            this.logon.Size = new System.Drawing.Size(75, 33);
            this.logon.TabIndex = 4;
            this.logon.Text = "登录";
            this.logon.UseVisualStyleBackColor = false;
            this.logon.Click += new System.EventHandler(this.logon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码";
            // 
            // close
            // 
            this.close.Image = global::AccountSystem.Properties.Resources.关闭1;
            this.close.Location = new System.Drawing.Point(417, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 42);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 7;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            // 
            // closered
            // 
            this.closered.Image = global::AccountSystem.Properties.Resources.关闭;
            this.closered.Location = new System.Drawing.Point(417, 60);
            this.closered.Name = "closered";
            this.closered.Size = new System.Drawing.Size(41, 41);
            this.closered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closered.TabIndex = 8;
            this.closered.TabStop = false;
            this.closered.Visible = false;
            // 
            // closetransp
            // 
            this.closetransp.Image = global::AccountSystem.Properties.Resources.关闭1;
            this.closetransp.Location = new System.Drawing.Point(417, 104);
            this.closetransp.Name = "closetransp";
            this.closetransp.Size = new System.Drawing.Size(41, 41);
            this.closetransp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closetransp.TabIndex = 9;
            this.closetransp.TabStop = false;
            this.closetransp.Visible = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(470, 290);
            this.Controls.Add(this.closetransp);
            this.Controls.Add(this.closered);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logon);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家用记账管理系统";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loading_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Loading_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closetransp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button logon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox closered;
        private System.Windows.Forms.PictureBox closetransp;
    }
}

