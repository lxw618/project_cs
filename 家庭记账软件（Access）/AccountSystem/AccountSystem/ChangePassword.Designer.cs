namespace AccountSystem
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.lbNickname = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbOldPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbRepeat = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.lbUsernameDisplay = new System.Windows.Forms.Label();
            this.lbNicknameDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNickname.ForeColor = System.Drawing.Color.White;
            this.lbNickname.Location = new System.Drawing.Point(55, 92);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(58, 24);
            this.lbNickname.TabIndex = 6;
            this.lbNickname.Text = "昵称";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(55, 32);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(82, 24);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "用户名";
            // 
            // lbOldPassword
            // 
            this.lbOldPassword.AutoSize = true;
            this.lbOldPassword.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOldPassword.ForeColor = System.Drawing.Color.White;
            this.lbOldPassword.Location = new System.Drawing.Point(55, 152);
            this.lbOldPassword.Name = "lbOldPassword";
            this.lbOldPassword.Size = new System.Drawing.Size(82, 24);
            this.lbOldPassword.TabIndex = 8;
            this.lbOldPassword.Text = "原密码";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNewPassword.ForeColor = System.Drawing.Color.White;
            this.lbNewPassword.Location = new System.Drawing.Point(55, 212);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(82, 24);
            this.lbNewPassword.TabIndex = 9;
            this.lbNewPassword.Text = "新密码";
            // 
            // lbRepeat
            // 
            this.lbRepeat.AutoSize = true;
            this.lbRepeat.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRepeat.ForeColor = System.Drawing.Color.White;
            this.lbRepeat.Location = new System.Drawing.Point(55, 272);
            this.lbRepeat.Name = "lbRepeat";
            this.lbRepeat.Size = new System.Drawing.Size(106, 24);
            this.lbRepeat.TabIndex = 10;
            this.lbRepeat.Text = "重复一次";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(168, 337);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 33);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtOldPassword.Location = new System.Drawing.Point(167, 150);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '●';
            this.txtOldPassword.Size = new System.Drawing.Size(183, 33);
            this.txtOldPassword.TabIndex = 12;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtNewPassword.Location = new System.Drawing.Point(167, 210);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(183, 33);
            this.txtNewPassword.TabIndex = 13;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRepeatPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtRepeatPassword.Location = new System.Drawing.Point(167, 270);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '●';
            this.txtRepeatPassword.Size = new System.Drawing.Size(183, 33);
            this.txtRepeatPassword.TabIndex = 14;
            // 
            // lbUsernameDisplay
            // 
            this.lbUsernameDisplay.AutoSize = true;
            this.lbUsernameDisplay.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsernameDisplay.ForeColor = System.Drawing.Color.White;
            this.lbUsernameDisplay.Location = new System.Drawing.Point(165, 32);
            this.lbUsernameDisplay.Name = "lbUsernameDisplay";
            this.lbUsernameDisplay.Size = new System.Drawing.Size(106, 24);
            this.lbUsernameDisplay.TabIndex = 15;
            this.lbUsernameDisplay.Text = "username";
            // 
            // lbNicknameDisplay
            // 
            this.lbNicknameDisplay.AutoSize = true;
            this.lbNicknameDisplay.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNicknameDisplay.ForeColor = System.Drawing.Color.White;
            this.lbNicknameDisplay.Location = new System.Drawing.Point(165, 92);
            this.lbNicknameDisplay.Name = "lbNicknameDisplay";
            this.lbNicknameDisplay.Size = new System.Drawing.Size(106, 24);
            this.lbNicknameDisplay.TabIndex = 16;
            this.lbNicknameDisplay.Text = "nickname";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(410, 385);
            this.Controls.Add(this.lbNicknameDisplay);
            this.Controls.Add(this.lbUsernameDisplay);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbRepeat);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.lbOldPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码重设";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbOldPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbRepeat;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label lbUsernameDisplay;
        private System.Windows.Forms.Label lbNicknameDisplay;
    }
}