namespace AccountSystem
{
    partial class MonthInstance
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
            this.dgvInstance = new System.Windows.Forms.DataGridView();
            this.btnFresh = new System.Windows.Forms.Button();
            this.cmbRange = new System.Windows.Forms.ComboBox();
            this.lbRange = new System.Windows.Forms.Label();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbGet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstance
            // 
            this.dgvInstance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstance.Location = new System.Drawing.Point(11, 72);
            this.dgvInstance.Name = "dgvInstance";
            this.dgvInstance.ReadOnly = true;
            this.dgvInstance.RowTemplate.Height = 23;
            this.dgvInstance.Size = new System.Drawing.Size(567, 314);
            this.dgvInstance.TabIndex = 115;
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnFresh.FlatAppearance.BorderSize = 0;
            this.btnFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresh.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFresh.ForeColor = System.Drawing.Color.White;
            this.btnFresh.Location = new System.Drawing.Point(479, 25);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(98, 33);
            this.btnFresh.TabIndex = 114;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // cmbRange
            // 
            this.cmbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRange.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRange.FormattingEnabled = true;
            this.cmbRange.ItemHeight = 25;
            this.cmbRange.Items.AddRange(new object[] {
            "个人",
            "家庭"});
            this.cmbRange.Location = new System.Drawing.Point(75, 25);
            this.cmbRange.Name = "cmbRange";
            this.cmbRange.Size = new System.Drawing.Size(150, 33);
            this.cmbRange.TabIndex = 113;
            this.cmbRange.SelectedValueChanged += new System.EventHandler(this.cmbRange_SelectedValueChanged);
            // 
            // lbRange
            // 
            this.lbRange.AutoSize = true;
            this.lbRange.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRange.ForeColor = System.Drawing.Color.White;
            this.lbRange.Location = new System.Drawing.Point(11, 27);
            this.lbRange.Name = "lbRange";
            this.lbRange.Size = new System.Drawing.Size(58, 24);
            this.lbRange.TabIndex = 112;
            this.lbRange.Text = "范围";
            // 
            // cmbUsername
            // 
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.ItemHeight = 25;
            this.cmbUsername.Location = new System.Drawing.Point(319, 25);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(154, 33);
            this.cmbUsername.TabIndex = 111;
            this.cmbUsername.SelectedValueChanged += new System.EventHandler(this.cmbUsername_SelectedValueChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(231, 27);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(82, 24);
            this.lbUsername.TabIndex = 110;
            this.lbUsername.Text = "用户名";
            // 
            // lbGet
            // 
            this.lbGet.AutoSize = true;
            this.lbGet.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbGet.ForeColor = System.Drawing.Color.White;
            this.lbGet.Location = new System.Drawing.Point(12, 399);
            this.lbGet.Name = "lbGet";
            this.lbGet.Size = new System.Drawing.Size(35, 21);
            this.lbGet.TabIndex = 116;
            this.lbGet.Text = "0元";
            // 
            // MonthInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(588, 429);
            this.Controls.Add(this.lbGet);
            this.Controls.Add(this.dgvInstance);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.cmbRange);
            this.Controls.Add(this.lbRange);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonthInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本月收支情况";
            this.Load += new System.EventHandler(this.MonthInstance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstance;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.ComboBox cmbRange;
        private System.Windows.Forms.Label lbRange;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbGet;
    }
}