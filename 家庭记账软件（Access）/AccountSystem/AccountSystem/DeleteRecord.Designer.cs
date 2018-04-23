namespace AccountSystem
{
    partial class DeleteRecord
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
            this.btnSearchRecord = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.dgvChangeRecord = new System.Windows.Forms.DataGridView();
            this.btnFresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRecord
            // 
            this.btnSearchRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnSearchRecord.FlatAppearance.BorderSize = 0;
            this.btnSearchRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRecord.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchRecord.ForeColor = System.Drawing.Color.White;
            this.btnSearchRecord.Location = new System.Drawing.Point(543, 30);
            this.btnSearchRecord.Name = "btnSearchRecord";
            this.btnSearchRecord.Size = new System.Drawing.Size(83, 33);
            this.btnSearchRecord.TabIndex = 93;
            this.btnSearchRecord.Text = "查询";
            this.btnSearchRecord.UseVisualStyleBackColor = false;
            this.btnSearchRecord.Click += new System.EventHandler(this.btnSearchRecord_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.dtpDate.Location = new System.Drawing.Point(365, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(157, 33);
            this.dtpDate.TabIndex = 92;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(253, 34);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(106, 24);
            this.lbDate.TabIndex = 91;
            this.lbDate.Text = "收支日期";
            // 
            // cmbUsername
            // 
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.ItemHeight = 25;
            this.cmbUsername.Location = new System.Drawing.Point(110, 29);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(122, 33);
            this.cmbUsername.TabIndex = 90;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(22, 31);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(82, 24);
            this.lbUsername.TabIndex = 89;
            this.lbUsername.Text = "用户名";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(321, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 33);
            this.btnDelete.TabIndex = 106;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbID
            // 
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbID.FormattingEnabled = true;
            this.cmbID.ItemHeight = 25;
            this.cmbID.Location = new System.Drawing.Point(126, 255);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(170, 33);
            this.cmbID.TabIndex = 105;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(23, 257);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(82, 24);
            this.lbID.TabIndex = 104;
            this.lbID.Text = "数据号";
            // 
            // dgvChangeRecord
            // 
            this.dgvChangeRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeRecord.Location = new System.Drawing.Point(27, 81);
            this.dgvChangeRecord.Name = "dgvChangeRecord";
            this.dgvChangeRecord.ReadOnly = true;
            this.dgvChangeRecord.RowTemplate.Height = 23;
            this.dgvChangeRecord.Size = new System.Drawing.Size(600, 158);
            this.dgvChangeRecord.TabIndex = 103;
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnFresh.FlatAppearance.BorderSize = 0;
            this.btnFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresh.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFresh.ForeColor = System.Drawing.Color.White;
            this.btnFresh.Location = new System.Drawing.Point(422, 255);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(83, 33);
            this.btnFresh.TabIndex = 107;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(649, 309);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dgvChangeRecord);
            this.Controls.Add(this.btnSearchRecord);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除收支记录";
            this.Load += new System.EventHandler(this.DeleteRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRecord;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView dgvChangeRecord;
        private System.Windows.Forms.Button btnFresh;
    }
}