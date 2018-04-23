namespace AccountSystem
{
    partial class UseAbout
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
            this.cmbRange = new System.Windows.Forms.ComboBox();
            this.lbHelp = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRange
            // 
            this.cmbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRange.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRange.FormattingEnabled = true;
            this.cmbRange.ItemHeight = 25;
            this.cmbRange.Items.AddRange(new object[] {
            "添加帐户",
            "删除帐户",
            "修改帐户信息",
            "添加收支记录",
            "删除收支记录",
            "修改收支记录",
            "重置密码",
            "注意事项"});
            this.cmbRange.Location = new System.Drawing.Point(132, 23);
            this.cmbRange.Name = "cmbRange";
            this.cmbRange.Size = new System.Drawing.Size(200, 33);
            this.cmbRange.TabIndex = 115;
            this.cmbRange.SelectedValueChanged += new System.EventHandler(this.cmbRange_SelectedValueChanged);
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHelp.ForeColor = System.Drawing.Color.White;
            this.lbHelp.Location = new System.Drawing.Point(20, 25);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(106, 24);
            this.lbHelp.TabIndex = 114;
            this.lbHelp.Text = "帮助页面";
            // 
            // lbContent
            // 
            this.lbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(192)))));
            this.lbContent.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbContent.ForeColor = System.Drawing.Color.White;
            this.lbContent.Location = new System.Drawing.Point(26, 68);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(306, 350);
            this.lbContent.TabIndex = 116;
            // 
            // UseAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(350, 439);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.cmbRange);
            this.Controls.Add(this.lbHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UseAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用说明";
            this.Load += new System.EventHandler(this.UseAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRange;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.Label lbContent;
    }
}