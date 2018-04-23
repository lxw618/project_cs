namespace AccountingSystem
{
    partial class ChangeRecord
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
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.dtpDateSearch = new System.Windows.Forms.DateTimePicker();
            this.lbMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbDateSearch = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvChangeRecord = new System.Windows.Forms.DataGridView();
            this.dptDate = new System.Windows.Forms.DateTimePicker();
            this.lbDat = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.cmbId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeRecord)).BeginInit();
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
            this.btnChange.Location = new System.Drawing.Point(242, 507);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 28);
            this.btnChange.TabIndex = 42;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(85, 41);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(147, 29);
            this.cmbUsername.TabIndex = 41;
            this.cmbUsername.SelectedValueChanged += new System.EventHandler(this.cmbUsername_SelectedValueChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(366, 321);
            this.cmbItem.MaxLength = 50;
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(154, 29);
            this.cmbItem.TabIndex = 40;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "收入",
            "支出"});
            this.cmbType.Location = new System.Drawing.Point(101, 321);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(154, 29);
            this.cmbType.TabIndex = 39;
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.Location = new System.Drawing.Point(101, 375);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(154, 29);
            this.txtMoney.TabIndex = 38;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMoney.ForeColor = System.Drawing.Color.White;
            this.lbMoney.Location = new System.Drawing.Point(21, 378);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(42, 21);
            this.lbMoney.TabIndex = 37;
            this.lbMoney.Text = "金额";
            // 
            // dtpDateSearch
            // 
            this.dtpDateSearch.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDateSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDateSearch.Location = new System.Drawing.Point(286, 41);
            this.dtpDateSearch.Name = "dtpDateSearch";
            this.dtpDateSearch.Size = new System.Drawing.Size(137, 29);
            this.dtpDateSearch.TabIndex = 36;
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemo.ForeColor = System.Drawing.Color.White;
            this.lbMemo.Location = new System.Drawing.Point(21, 426);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(42, 21);
            this.lbMemo.TabIndex = 35;
            this.lbMemo.Text = "备注";
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMemo.Location = new System.Drawing.Point(101, 426);
            this.txtMemo.MaxLength = 50;
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(419, 61);
            this.txtMemo.TabIndex = 34;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(21, 324);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(74, 21);
            this.lbType.TabIndex = 33;
            this.lbType.Text = "收支类别";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItem.ForeColor = System.Drawing.Color.White;
            this.lbItem.Location = new System.Drawing.Point(286, 324);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(74, 21);
            this.lbItem.TabIndex = 32;
            this.lbItem.Text = "收支项目";
            // 
            // lbDateSearch
            // 
            this.lbDateSearch.AutoSize = true;
            this.lbDateSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateSearch.ForeColor = System.Drawing.Color.White;
            this.lbDateSearch.Location = new System.Drawing.Point(238, 44);
            this.lbDateSearch.Name = "lbDateSearch";
            this.lbDateSearch.Size = new System.Drawing.Size(42, 21);
            this.lbDateSearch.TabIndex = 31;
            this.lbDateSearch.Text = "日期";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(21, 44);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 21);
            this.lbUsername.TabIndex = 30;
            this.lbUsername.Text = "用户名";
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
            this.btnSearch.Location = new System.Drawing.Point(445, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvChangeRecord
            // 
            this.dgvChangeRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeRecord.Location = new System.Drawing.Point(25, 91);
            this.dgvChangeRecord.Name = "dgvChangeRecord";
            this.dgvChangeRecord.ReadOnly = true;
            this.dgvChangeRecord.RowTemplate.Height = 23;
            this.dgvChangeRecord.Size = new System.Drawing.Size(495, 157);
            this.dgvChangeRecord.TabIndex = 44;
            // 
            // dptDate
            // 
            this.dptDate.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dptDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dptDate.Location = new System.Drawing.Point(366, 266);
            this.dptDate.Name = "dptDate";
            this.dptDate.Size = new System.Drawing.Size(154, 29);
            this.dptDate.TabIndex = 46;
            // 
            // lbDat
            // 
            this.lbDat.AutoSize = true;
            this.lbDat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDat.ForeColor = System.Drawing.Color.White;
            this.lbDat.Location = new System.Drawing.Point(286, 269);
            this.lbDat.Name = "lbDat";
            this.lbDat.Size = new System.Drawing.Size(42, 21);
            this.lbDat.TabIndex = 45;
            this.lbDat.Text = "日期";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(21, 269);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(58, 21);
            this.lbId.TabIndex = 47;
            this.lbId.Text = "数据号";
            // 
            // cmbId
            // 
            this.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(101, 266);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(154, 29);
            this.cmbId.TabIndex = 48;
            this.cmbId.SelectedValueChanged += new System.EventHandler(this.cmbId_SelectedValueChanged);
            // 
            // ChangeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(553, 560);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.dptDate);
            this.Controls.Add(this.lbDat);
            this.Controls.Add(this.dgvChangeRecord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.dtpDateSearch);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.lbDateSearch);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改收支记录";
            this.Load += new System.EventHandler(this.ChangeRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.DateTimePicker dtpDateSearch;
        private System.Windows.Forms.Label lbMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbDateSearch;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvChangeRecord;
        private System.Windows.Forms.DateTimePicker dptDate;
        private System.Windows.Forms.Label lbDat;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.ComboBox cmbId;
    }
}