namespace AccountingSystem
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.lbAccountStyle = new System.Windows.Forms.Label();
            this.lbFamilyCall = new System.Windows.Forms.Label();
            this.lbNickname = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtAccountStyle = new System.Windows.Forms.Label();
            this.txtFamilyCall = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(119, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(139, 32);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(132, 29);
            this.cmbUsername.TabIndex = 29;
            this.cmbUsername.SelectedValueChanged += new System.EventHandler(this.cmbUsername_SelectedValueChanged);
            // 
            // lbAccountStyle
            // 
            this.lbAccountStyle.AutoSize = true;
            this.lbAccountStyle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAccountStyle.ForeColor = System.Drawing.Color.White;
            this.lbAccountStyle.Location = new System.Drawing.Point(41, 209);
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
            this.lbFamilyCall.Location = new System.Drawing.Point(41, 149);
            this.lbFamilyCall.Name = "lbFamilyCall";
            this.lbFamilyCall.Size = new System.Drawing.Size(74, 21);
            this.lbFamilyCall.TabIndex = 22;
            this.lbFamilyCall.Text = "家庭称呼";
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNickname.ForeColor = System.Drawing.Color.White;
            this.lbNickname.Location = new System.Drawing.Point(43, 91);
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
            this.lbUsername.Location = new System.Drawing.Point(41, 35);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 21);
            this.lbUsername.TabIndex = 18;
            this.lbUsername.Text = "用户名";
            // 
            // txtAccountStyle
            // 
            this.txtAccountStyle.AutoSize = true;
            this.txtAccountStyle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccountStyle.ForeColor = System.Drawing.Color.White;
            this.txtAccountStyle.Location = new System.Drawing.Point(140, 209);
            this.txtAccountStyle.Name = "txtAccountStyle";
            this.txtAccountStyle.Size = new System.Drawing.Size(122, 21);
            this.txtAccountStyle.TabIndex = 31;
            this.txtAccountStyle.Text = "账户类型显示区";
            // 
            // txtFamilyCall
            // 
            this.txtFamilyCall.AutoSize = true;
            this.txtFamilyCall.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFamilyCall.ForeColor = System.Drawing.Color.White;
            this.txtFamilyCall.Location = new System.Drawing.Point(140, 149);
            this.txtFamilyCall.Name = "txtFamilyCall";
            this.txtFamilyCall.Size = new System.Drawing.Size(122, 21);
            this.txtFamilyCall.TabIndex = 32;
            this.txtFamilyCall.Text = "家庭称呼显示区";
            // 
            // txtNickname
            // 
            this.txtNickname.AutoSize = true;
            this.txtNickname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNickname.ForeColor = System.Drawing.Color.White;
            this.txtNickname.Location = new System.Drawing.Point(140, 91);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(90, 21);
            this.txtNickname.TabIndex = 33;
            this.txtNickname.Text = "昵称显示区";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(300, 316);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.txtFamilyCall);
            this.Controls.Add(this.txtAccountStyle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.lbAccountStyle);
            this.Controls.Add(this.lbFamilyCall);
            this.Controls.Add(this.lbNickname);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除账户";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label lbAccountStyle;
        private System.Windows.Forms.Label lbFamilyCall;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label txtAccountStyle;
        private System.Windows.Forms.Label txtFamilyCall;
        private System.Windows.Forms.Label txtNickname;
    }
}