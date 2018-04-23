namespace AccountingSystem
{
    partial class SendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmail));
            this.lbTitle = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lbRecipent = new System.Windows.Forms.Label();
            this.lbTheme = new System.Windows.Forms.Label();
            this.lbCopy = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtRecipent = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(133, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "邮件发送";
            // 
            // picClose
            // 
            this.picClose.Image = global::AccountingSystem.Properties.Resources.Close1;
            this.picClose.Location = new System.Drawing.Point(437, 9);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(39, 42);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 26;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseClick);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            // 
            // lbRecipent
            // 
            this.lbRecipent.AutoSize = true;
            this.lbRecipent.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRecipent.ForeColor = System.Drawing.Color.White;
            this.lbRecipent.Location = new System.Drawing.Point(14, 77);
            this.lbRecipent.Name = "lbRecipent";
            this.lbRecipent.Size = new System.Drawing.Size(69, 26);
            this.lbRecipent.TabIndex = 27;
            this.lbRecipent.Text = "收件人";
            // 
            // lbTheme
            // 
            this.lbTheme.AutoSize = true;
            this.lbTheme.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTheme.ForeColor = System.Drawing.Color.White;
            this.lbTheme.Location = new System.Drawing.Point(14, 122);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(50, 26);
            this.lbTheme.TabIndex = 28;
            this.lbTheme.Text = "主题";
            // 
            // lbCopy
            // 
            this.lbCopy.AutoSize = true;
            this.lbCopy.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCopy.ForeColor = System.Drawing.Color.White;
            this.lbCopy.Location = new System.Drawing.Point(14, 168);
            this.lbCopy.Name = "lbCopy";
            this.lbCopy.Size = new System.Drawing.Size(50, 26);
            this.lbCopy.TabIndex = 29;
            this.lbCopy.Text = "抄送";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbContent.ForeColor = System.Drawing.Color.White;
            this.lbContent.Location = new System.Drawing.Point(14, 213);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(50, 26);
            this.lbContent.TabIndex = 30;
            this.lbContent.Text = "内容";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(19, 247);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(445, 173);
            this.txtContent.TabIndex = 31;
            // 
            // txtRecipent
            // 
            this.txtRecipent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecipent.Location = new System.Drawing.Point(90, 77);
            this.txtRecipent.Name = "txtRecipent";
            this.txtRecipent.Size = new System.Drawing.Size(264, 29);
            this.txtRecipent.TabIndex = 32;
            // 
            // txtTheme
            // 
            this.txtTheme.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTheme.Location = new System.Drawing.Point(90, 122);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(264, 29);
            this.txtTheme.TabIndex = 33;
            // 
            // txtCopy
            // 
            this.txtCopy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCopy.Location = new System.Drawing.Point(90, 168);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(264, 29);
            this.txtCopy.TabIndex = 34;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(182)))), ((int)(((byte)(240)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(377, 120);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 28);
            this.btnSend.TabIndex = 36;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.btnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(182)))), ((int)(((byte)(240)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(377, 78);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(87, 28);
            this.btnSet.TabIndex = 37;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(111)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtRecipent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbCopy);
            this.Controls.Add(this.lbTheme);
            this.Controls.Add(this.lbRecipent);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "邮件发送";
            this.Load += new System.EventHandler(this.SendEmail_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SendEmail_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SendEmail_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbRecipent;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.Label lbCopy;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtRecipent;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSet;
    }
}