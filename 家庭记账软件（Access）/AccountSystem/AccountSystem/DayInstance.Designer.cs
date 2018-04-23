namespace AccountSystem
{
    partial class DayInstance
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.cmbRange = new System.Windows.Forms.ComboBox();
            this.lbRange = new System.Windows.Forms.Label();
            this.btnFresh = new System.Windows.Forms.Button();
            this.dgvInstance = new System.Windows.Forms.DataGridView();
            this.lbGet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstance)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsername
            // 
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.ItemHeight = 25;
            this.cmbUsername.Location = new System.Drawing.Point(320, 19);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(154, 33);
            this.cmbUsername.TabIndex = 92;
            this.cmbUsername.SelectedValueChanged += new System.EventHandler(this.cmbUsername_SelectedValueChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(232, 21);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(82, 24);
            this.lbUsername.TabIndex = 91;
            this.lbUsername.Text = "用户名";
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
            this.cmbRange.Location = new System.Drawing.Point(76, 19);
            this.cmbRange.Name = "cmbRange";
            this.cmbRange.Size = new System.Drawing.Size(150, 33);
            this.cmbRange.TabIndex = 94;
            this.cmbRange.SelectedValueChanged += new System.EventHandler(this.cmbRange_SelectedValueChanged);
            // 
            // lbRange
            // 
            this.lbRange.AutoSize = true;
            this.lbRange.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRange.ForeColor = System.Drawing.Color.White;
            this.lbRange.Location = new System.Drawing.Point(12, 21);
            this.lbRange.Name = "lbRange";
            this.lbRange.Size = new System.Drawing.Size(58, 24);
            this.lbRange.TabIndex = 93;
            this.lbRange.Text = "范围";
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnFresh.FlatAppearance.BorderSize = 0;
            this.btnFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresh.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFresh.ForeColor = System.Drawing.Color.White;
            this.btnFresh.Location = new System.Drawing.Point(480, 19);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(98, 33);
            this.btnFresh.TabIndex = 108;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // dgvInstance
            // 
            this.dgvInstance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstance.Location = new System.Drawing.Point(12, 60);
            this.dgvInstance.Name = "dgvInstance";
            this.dgvInstance.ReadOnly = true;
            this.dgvInstance.RowTemplate.Height = 23;
            this.dgvInstance.Size = new System.Drawing.Size(567, 314);
            this.dgvInstance.TabIndex = 109;
            // 
            // lbGet
            // 
            this.lbGet.AutoSize = true;
            this.lbGet.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbGet.ForeColor = System.Drawing.Color.White;
            this.lbGet.Location = new System.Drawing.Point(12, 391);
            this.lbGet.Name = "lbGet";
            this.lbGet.Size = new System.Drawing.Size(35, 21);
            this.lbGet.TabIndex = 110;
            this.lbGet.Text = "0元";
            // 
            // DayInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(592, 427);
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
            this.Name = "DayInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "当日收支情况";
            this.Load += new System.EventHandler(this.DayInstance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.ComboBox cmbRange;
        private System.Windows.Forms.Label lbRange;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.DataGridView dgvInstance;
        private System.Windows.Forms.Label lbGet;
    }
}