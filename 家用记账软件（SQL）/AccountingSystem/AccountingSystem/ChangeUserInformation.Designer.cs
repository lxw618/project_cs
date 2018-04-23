namespace AccountingSystem
{
    partial class ChangeUserInformation
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
            this.btnChange = new System.Windows.Forms.Button();
            this.cmbAccountStyle = new System.Windows.Forms.ComboBox();
            this.txtFamilyCall = new System.Windows.Forms.TextBox();
            this.lbAccountStyle = new System.Windows.Forms.Label();
            this.lbFamilyCall = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lbNickname = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(164, 283);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 28);
            this.btnChange.TabIndex = 30;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cmbAccountStyle
            // 
            this.cmbAccountStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountStyle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAccountStyle.FormattingEnabled = true;
            this.cmbAccountStyle.Items.AddRange(new object[] {
            "普通",
            "管理员"});
            this.cmbAccountStyle.Location = new System.Drawing.Point(164, 220);
            this.cmbAccountStyle.Name = "cmbAccountStyle";
            this.cmbAccountStyle.Size = new System.Drawing.Size(132, 29);
            this.cmbAccountStyle.TabIndex = 29;
            // 
            // txtFamilyCall
            // 
            this.txtFamilyCall.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFamilyCall.Location = new System.Drawing.Point(164, 160);
            this.txtFamilyCall.MaxLength = 50;
            this.txtFamilyCall.Name = "txtFamilyCall";
            this.txtFamilyCall.Size = new System.Drawing.Size(132, 29);
            this.txtFamilyCall.TabIndex = 26;
            // 
            // lbAccountStyle
            // 
            this.lbAccountStyle.AutoSize = true;
            this.lbAccountStyle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAccountStyle.ForeColor = System.Drawing.Color.White;
            this.lbAccountStyle.Location = new System.Drawing.Point(66, 223);
            this.lbAccountStyle.Name = "lbAccountStyle";
            this.lbAccountStyle.Size = new System.Drawing.Size(74, 21);
            this.lbAccountStyle.TabIndex = 23;
            this.lbAccountStyle.Text = "账户类型";
            // 
            // lbFamilyCall
            // 
            this.lbFamilyCall.AutoSize = true;
            this.lbFamilyCall.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFamilyCall.ForeColor = System.Drawing.Color.White;
            this.lbFamilyCall.Location = new System.Drawing.Point(66, 163);
            this.lbFamilyCall.Name = "lbFamilyCall";
            this.lbFamilyCall.Size = new System.Drawing.Size(74, 21);
            this.lbFamilyCall.TabIndex = 22;
            this.lbFamilyCall.Text = "家庭称呼";
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNickname.Location = new System.Drawing.Point(164, 102);
            this.txtNickname.MaxLength = 50;
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(132, 29);
            this.txtNickname.TabIndex = 21;
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNickname.ForeColor = System.Drawing.Color.White;
            this.lbNickname.Location = new System.Drawing.Point(68, 105);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(42, 21);
            this.lbNickname.TabIndex = 20;
            this.lbNickname.Text = "昵称";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(66, 49);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 21);
            this.lbUsername.TabIndex = 18;
            this.lbUsername.Text = "用户名";
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(164, 46);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(132, 29);
            this.cmbUsername.TabIndex = 31;
            this.cmbUsername.SelectedValueChanged += new System.EventHandler(this.cmbUsername_SelectedValueChanged);
            // 
            // ChangeUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(378, 341);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cmbAccountStyle);
            this.Controls.Add(this.txtFamilyCall);
            this.Controls.Add(this.lbAccountStyle);
            this.Controls.Add(this.lbFamilyCall);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lbNickname);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改账户信息";
            this.Load += new System.EventHandler(this.ChangeUserInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cmbAccountStyle;
        private System.Windows.Forms.TextBox txtFamilyCall;
        private System.Windows.Forms.Label lbAccountStyle;
        private System.Windows.Forms.Label lbFamilyCall;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.ComboBox cmbUsername;
    }
}