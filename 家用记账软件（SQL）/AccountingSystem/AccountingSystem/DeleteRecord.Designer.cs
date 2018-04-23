namespace AccountingSystem
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbDat = new System.Windows.Forms.Label();
            this.dgvDeleteRecord = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.dtpDateSearch = new System.Windows.Forms.DateTimePicker();
            this.lbMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbDateSearch = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteRecord)).BeginInit();
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
            this.btnDelete.Location = new System.Drawing.Point(260, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbId
            // 
            this.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(128, 261);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(154, 29);
            this.cmbId.TabIndex = 66;
            this.cmbId.SelectedValueChanged += new System.EventHandler(this.cmbId_SelectedValueChanged);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(48, 264);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(58, 21);
            this.lbId.TabIndex = 65;
            this.lbId.Text = "数据号";
            // 
            // lbDat
            // 
            this.lbDat.AutoSize = true;
            this.lbDat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDat.ForeColor = System.Drawing.Color.White;
            this.lbDat.Location = new System.Drawing.Point(313, 264);
            this.lbDat.Name = "lbDat";
            this.lbDat.Size = new System.Drawing.Size(42, 21);
            this.lbDat.TabIndex = 63;
            this.lbDat.Text = "日期";
            // 
            // dgvDeleteRecord
            // 
            this.dgvDeleteRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteRecord.Location = new System.Drawing.Point(52, 86);
            this.dgvDeleteRecord.Name = "dgvDeleteRecord";
            this.dgvDeleteRecord.ReadOnly = true;
            this.dgvDeleteRecord.RowTemplate.Height = 23;
            this.dgvDeleteRecord.Size = new System.Drawing.Size(495, 157);
            this.dgvDeleteRecord.TabIndex = 62;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(472, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(112, 36);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(147, 29);
            this.cmbUsername.TabIndex = 60;
            this.cmbUsername.SelectedValueChanged += new System.EventHandler(this.cmbUsername_SelectedValueChanged);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.Location = new System.Drawing.Point(128, 370);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(154, 29);
            this.txtMoney.TabIndex = 57;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMoney.ForeColor = System.Drawing.Color.White;
            this.lbMoney.Location = new System.Drawing.Point(48, 373);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(42, 21);
            this.lbMoney.TabIndex = 56;
            this.lbMoney.Text = "金额";
            // 
            // dtpDateSearch
            // 
            this.dtpDateSearch.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDateSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDateSearch.Location = new System.Drawing.Point(313, 36);
            this.dtpDateSearch.Name = "dtpDateSearch";
            this.dtpDateSearch.Size = new System.Drawing.Size(137, 29);
            this.dtpDateSearch.TabIndex = 55;
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemo.ForeColor = System.Drawing.Color.White;
            this.lbMemo.Location = new System.Drawing.Point(48, 421);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(42, 21);
            this.lbMemo.TabIndex = 54;
            this.lbMemo.Text = "备注";
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMemo.Location = new System.Drawing.Point(128, 421);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ReadOnly = true;
            this.txtMemo.Size = new System.Drawing.Size(419, 61);
            this.txtMemo.TabIndex = 53;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(48, 319);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(74, 21);
            this.lbType.TabIndex = 52;
            this.lbType.Text = "收支类别";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItem.ForeColor = System.Drawing.Color.White;
            this.lbItem.Location = new System.Drawing.Point(313, 319);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(74, 21);
            this.lbItem.TabIndex = 51;
            this.lbItem.Text = "收支项目";
            // 
            // lbDateSearch
            // 
            this.lbDateSearch.AutoSize = true;
            this.lbDateSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateSearch.ForeColor = System.Drawing.Color.White;
            this.lbDateSearch.Location = new System.Drawing.Point(265, 39);
            this.lbDateSearch.Name = "lbDateSearch";
            this.lbDateSearch.Size = new System.Drawing.Size(42, 21);
            this.lbDateSearch.TabIndex = 50;
            this.lbDateSearch.Text = "日期";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(48, 39);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 21);
            this.lbUsername.TabIndex = 49;
            this.lbUsername.Text = "用户名";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtType.Location = new System.Drawing.Point(128, 316);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(154, 29);
            this.txtType.TabIndex = 67;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtItem.Location = new System.Drawing.Point(393, 316);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(154, 29);
            this.txtItem.TabIndex = 68;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDate.Location = new System.Drawing.Point(393, 261);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(154, 29);
            this.txtDate.TabIndex = 69;
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(595, 555);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbDat);
            this.Controls.Add(this.dgvDeleteRecord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.dtpDateSearch);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.lbDateSearch);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除收支记录";
            this.Load += new System.EventHandler(this.DeleteRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbDat;
        private System.Windows.Forms.DataGridView dgvDeleteRecord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.DateTimePicker dtpDateSearch;
        private System.Windows.Forms.Label lbMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbDateSearch;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtDate;
    }
}