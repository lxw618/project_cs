namespace AccountSystem
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnSearchRecord = new System.Windows.Forms.Button();
            this.dgvChangeRecord = new System.Windows.Forms.DataGridView();
            this.dptDateNew = new System.Windows.Forms.DateTimePicker();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.lbMemo = new System.Windows.Forms.Label();
            this.lbStyle = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbDateNew = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnFresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.dtpDate.Location = new System.Drawing.Point(355, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(157, 33);
            this.dtpDate.TabIndex = 87;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(243, 28);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(106, 24);
            this.lbDate.TabIndex = 86;
            this.lbDate.Text = "收支日期";
            // 
            // cmbUsername
            // 
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.ItemHeight = 25;
            this.cmbUsername.Location = new System.Drawing.Point(100, 23);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(122, 33);
            this.cmbUsername.TabIndex = 85;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(12, 25);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(82, 24);
            this.lbUsername.TabIndex = 84;
            this.lbUsername.Text = "用户名";
            // 
            // btnSearchRecord
            // 
            this.btnSearchRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnSearchRecord.FlatAppearance.BorderSize = 0;
            this.btnSearchRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRecord.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchRecord.ForeColor = System.Drawing.Color.White;
            this.btnSearchRecord.Location = new System.Drawing.Point(533, 24);
            this.btnSearchRecord.Name = "btnSearchRecord";
            this.btnSearchRecord.Size = new System.Drawing.Size(83, 33);
            this.btnSearchRecord.TabIndex = 88;
            this.btnSearchRecord.Text = "查询";
            this.btnSearchRecord.UseVisualStyleBackColor = false;
            this.btnSearchRecord.Click += new System.EventHandler(this.btnSearchRecord_Click);
            // 
            // dgvChangeRecord
            // 
            this.dgvChangeRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeRecord.Location = new System.Drawing.Point(17, 75);
            this.dgvChangeRecord.Name = "dgvChangeRecord";
            this.dgvChangeRecord.ReadOnly = true;
            this.dgvChangeRecord.RowTemplate.Height = 23;
            this.dgvChangeRecord.Size = new System.Drawing.Size(600, 136);
            this.dgvChangeRecord.TabIndex = 89;
            // 
            // dptDateNew
            // 
            this.dptDateNew.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.dptDateNew.Location = new System.Drawing.Point(433, 226);
            this.dptDateNew.Name = "dptDateNew";
            this.dptDateNew.Size = new System.Drawing.Size(183, 33);
            this.dptDateNew.TabIndex = 101;
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMemo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMemo.Location = new System.Drawing.Point(120, 364);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemo.Size = new System.Drawing.Size(496, 52);
            this.txtMemo.TabIndex = 100;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtItem.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtItem.Location = new System.Drawing.Point(433, 272);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(183, 33);
            this.txtItem.TabIndex = 99;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMoney.Location = new System.Drawing.Point(120, 272);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(183, 33);
            this.txtMoney.TabIndex = 98;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // cmbStyle
            // 
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.ItemHeight = 25;
            this.cmbStyle.Items.AddRange(new object[] {
            "收入",
            "支出"});
            this.cmbStyle.Location = new System.Drawing.Point(120, 318);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(183, 33);
            this.cmbStyle.TabIndex = 97;
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemo.ForeColor = System.Drawing.Color.White;
            this.lbMemo.Location = new System.Drawing.Point(12, 366);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(58, 24);
            this.lbMemo.TabIndex = 96;
            this.lbMemo.Text = "备注";
            // 
            // lbStyle
            // 
            this.lbStyle.AutoSize = true;
            this.lbStyle.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStyle.ForeColor = System.Drawing.Color.White;
            this.lbStyle.Location = new System.Drawing.Point(8, 318);
            this.lbStyle.Name = "lbStyle";
            this.lbStyle.Size = new System.Drawing.Size(106, 24);
            this.lbStyle.TabIndex = 95;
            this.lbStyle.Text = "收支类型";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItem.ForeColor = System.Drawing.Color.White;
            this.lbItem.Location = new System.Drawing.Point(322, 276);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(106, 24);
            this.lbItem.TabIndex = 94;
            this.lbItem.Text = "收支项目";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMoney.ForeColor = System.Drawing.Color.White;
            this.lbMoney.Location = new System.Drawing.Point(8, 274);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(106, 24);
            this.lbMoney.TabIndex = 93;
            this.lbMoney.Text = "金额(￥)";
            // 
            // lbDateNew
            // 
            this.lbDateNew.AutoSize = true;
            this.lbDateNew.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateNew.ForeColor = System.Drawing.Color.White;
            this.lbDateNew.Location = new System.Drawing.Point(320, 228);
            this.lbDateNew.Name = "lbDateNew";
            this.lbDateNew.Size = new System.Drawing.Size(106, 24);
            this.lbDateNew.TabIndex = 92;
            this.lbDateNew.Text = "收支日期";
            // 
            // cmbID
            // 
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbID.FormattingEnabled = true;
            this.cmbID.ItemHeight = 25;
            this.cmbID.Location = new System.Drawing.Point(120, 226);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(183, 33);
            this.cmbID.TabIndex = 91;
            this.cmbID.SelectedValueChanged += new System.EventHandler(this.cmbID_SelectedValueChanged);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(8, 228);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(82, 24);
            this.lbID.TabIndex = 90;
            this.lbID.Text = "数据号";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(345, 422);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(83, 33);
            this.btnChange.TabIndex = 102;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnFresh.FlatAppearance.BorderSize = 0;
            this.btnFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresh.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFresh.ForeColor = System.Drawing.Color.White;
            this.btnFresh.Location = new System.Drawing.Point(232, 422);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(83, 33);
            this.btnFresh.TabIndex = 103;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // ChangeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(644, 469);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.dptDateNew);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.cmbStyle);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.lbStyle);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.lbDateNew);
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
            this.Name = "ChangeRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改收支记录";
            this.Load += new System.EventHandler(this.ChangeRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnSearchRecord;
        private System.Windows.Forms.DataGridView dgvChangeRecord;
        private System.Windows.Forms.DateTimePicker dptDateNew;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.Label lbMemo;
        private System.Windows.Forms.Label lbStyle;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbDateNew;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnFresh;
    }
}