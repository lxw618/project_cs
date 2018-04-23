namespace AccountSystem
{
    partial class DeleteUser
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
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lbAccountStyle = new System.Windows.Forms.Label();
            this.txtFamilyCall = new System.Windows.Forms.TextBox();
            this.txtTrueName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lbFamilyCall = new System.Windows.Forms.Label();
            this.lbTrueName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbNickname = new System.Windows.Forms.Label();
            this.txtAccountStyle = new System.Windows.Forms.TextBox();
            this.btnFresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.ItemHeight = 25;
            this.cmbUsername.Location = new System.Drawing.Point(138, 31);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(183, 33);
            this.cmbUsername.TabIndex = 70;
            this.cmbUsername.SelectedValueChanged += new System.EventHandler(this.cmbUsername_SelectedValueChanged);
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNickname.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtNickname.Location = new System.Drawing.Point(138, 93);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.ReadOnly = true;
            this.txtNickname.Size = new System.Drawing.Size(183, 33);
            this.txtNickname.TabIndex = 65;
            // 
            // lbAccountStyle
            // 
            this.lbAccountStyle.AutoSize = true;
            this.lbAccountStyle.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAccountStyle.ForeColor = System.Drawing.Color.White;
            this.lbAccountStyle.Location = new System.Drawing.Point(26, 335);
            this.lbAccountStyle.Name = "lbAccountStyle";
            this.lbAccountStyle.Size = new System.Drawing.Size(106, 24);
            this.lbAccountStyle.TabIndex = 63;
            this.lbAccountStyle.Text = "账户类型";
            // 
            // txtFamilyCall
            // 
            this.txtFamilyCall.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFamilyCall.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtFamilyCall.Location = new System.Drawing.Point(138, 271);
            this.txtFamilyCall.Name = "txtFamilyCall";
            this.txtFamilyCall.ReadOnly = true;
            this.txtFamilyCall.Size = new System.Drawing.Size(183, 33);
            this.txtFamilyCall.TabIndex = 62;
            // 
            // txtTrueName
            // 
            this.txtTrueName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTrueName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTrueName.Location = new System.Drawing.Point(138, 211);
            this.txtTrueName.Name = "txtTrueName";
            this.txtTrueName.ReadOnly = true;
            this.txtTrueName.Size = new System.Drawing.Size(183, 33);
            this.txtTrueName.TabIndex = 61;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPassword.Location = new System.Drawing.Point(138, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(183, 33);
            this.txtPassword.TabIndex = 60;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(199, 396);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(83, 33);
            this.btnDeleteUser.TabIndex = 59;
            this.btnDeleteUser.Text = "删除";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lbFamilyCall
            // 
            this.lbFamilyCall.AutoSize = true;
            this.lbFamilyCall.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFamilyCall.ForeColor = System.Drawing.Color.White;
            this.lbFamilyCall.Location = new System.Drawing.Point(26, 273);
            this.lbFamilyCall.Name = "lbFamilyCall";
            this.lbFamilyCall.Size = new System.Drawing.Size(106, 24);
            this.lbFamilyCall.TabIndex = 58;
            this.lbFamilyCall.Text = "家庭称呼";
            // 
            // lbTrueName
            // 
            this.lbTrueName.AutoSize = true;
            this.lbTrueName.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTrueName.ForeColor = System.Drawing.Color.White;
            this.lbTrueName.Location = new System.Drawing.Point(26, 213);
            this.lbTrueName.Name = "lbTrueName";
            this.lbTrueName.Size = new System.Drawing.Size(106, 24);
            this.lbTrueName.TabIndex = 57;
            this.lbTrueName.Text = "真实姓名";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(26, 153);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(58, 24);
            this.lbPassword.TabIndex = 56;
            this.lbPassword.Text = "密码";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(26, 33);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(82, 24);
            this.lbUsername.TabIndex = 55;
            this.lbUsername.Text = "用户名";
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNickname.ForeColor = System.Drawing.Color.White;
            this.lbNickname.Location = new System.Drawing.Point(26, 93);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(58, 24);
            this.lbNickname.TabIndex = 54;
            this.lbNickname.Text = "昵称";
            // 
            // txtAccountStyle
            // 
            this.txtAccountStyle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccountStyle.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAccountStyle.Location = new System.Drawing.Point(138, 333);
            this.txtAccountStyle.Name = "txtAccountStyle";
            this.txtAccountStyle.ReadOnly = true;
            this.txtAccountStyle.Size = new System.Drawing.Size(183, 33);
            this.txtAccountStyle.TabIndex = 71;
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnFresh.FlatAppearance.BorderSize = 0;
            this.btnFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresh.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFresh.ForeColor = System.Drawing.Color.White;
            this.btnFresh.Location = new System.Drawing.Point(68, 396);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(82, 33);
            this.btnFresh.TabIndex = 72;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(355, 441);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.txtAccountStyle);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lbAccountStyle);
            this.Controls.Add(this.txtFamilyCall);
            this.Controls.Add(this.txtTrueName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.lbFamilyCall);
            this.Controls.Add(this.lbTrueName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除用户";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lbAccountStyle;
        private System.Windows.Forms.TextBox txtFamilyCall;
        private System.Windows.Forms.TextBox txtTrueName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lbFamilyCall;
        private System.Windows.Forms.Label lbTrueName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.TextBox txtAccountStyle;
        private System.Windows.Forms.Button btnFresh;
    }
}