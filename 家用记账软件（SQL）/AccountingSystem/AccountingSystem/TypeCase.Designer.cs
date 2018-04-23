namespace AccountingSystem
{
    partial class TypeCase
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
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbRange = new System.Windows.Forms.Label();
            this.lbDataRange = new System.Windows.Forms.Label();
            this.dtpDateRange = new System.Windows.Forms.DateTimePicker();
            this.cmbWay = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbStatisticsWay = new System.Windows.Forms.Label();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRange
            // 
            this.cmbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRange.FormattingEnabled = true;
            this.cmbRange.Items.AddRange(new object[] {
            "个人",
            "家庭"});
            this.cmbRange.Location = new System.Drawing.Point(99, 33);
            this.cmbRange.Name = "cmbRange";
            this.cmbRange.Size = new System.Drawing.Size(139, 29);
            this.cmbRange.TabIndex = 90;
            this.cmbRange.SelectedIndexChanged += new System.EventHandler(this.cmbRange_SelectedIndexChanged);
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(340, 33);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(146, 29);
            this.cmbUsername.TabIndex = 89;
            this.cmbUsername.SelectedIndexChanged += new System.EventHandler(this.cmbUsername_SelectedIndexChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(260, 36);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 21);
            this.lbUsername.TabIndex = 88;
            this.lbUsername.Text = "用户名";
            // 
            // lbRange
            // 
            this.lbRange.AutoSize = true;
            this.lbRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRange.ForeColor = System.Drawing.Color.White;
            this.lbRange.Location = new System.Drawing.Point(21, 36);
            this.lbRange.Name = "lbRange";
            this.lbRange.Size = new System.Drawing.Size(42, 21);
            this.lbRange.TabIndex = 87;
            this.lbRange.Text = "范围";
            // 
            // lbDataRange
            // 
            this.lbDataRange.AutoSize = true;
            this.lbDataRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDataRange.ForeColor = System.Drawing.Color.White;
            this.lbDataRange.Location = new System.Drawing.Point(21, 85);
            this.lbDataRange.Name = "lbDataRange";
            this.lbDataRange.Size = new System.Drawing.Size(74, 21);
            this.lbDataRange.TabIndex = 91;
            this.lbDataRange.Text = "日期范围";
            // 
            // dtpDateRange
            // 
            this.dtpDateRange.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDateRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpDateRange.Location = new System.Drawing.Point(101, 85);
            this.dtpDateRange.Name = "dtpDateRange";
            this.dtpDateRange.Size = new System.Drawing.Size(137, 29);
            this.dtpDateRange.TabIndex = 92;
            this.dtpDateRange.ValueChanged += new System.EventHandler(this.dtpDateRange_ValueChanged);
            // 
            // cmbWay
            // 
            this.cmbWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbWay.FormattingEnabled = true;
            this.cmbWay.Items.AddRange(new object[] {
            "按日统计",
            "按月统计",
            "按年统计"});
            this.cmbWay.Location = new System.Drawing.Point(340, 85);
            this.cmbWay.Name = "cmbWay";
            this.cmbWay.Size = new System.Drawing.Size(146, 29);
            this.cmbWay.TabIndex = 93;
            this.cmbWay.SelectedIndexChanged += new System.EventHandler(this.cmbWay_SelectedIndexChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(340, 137);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(146, 29);
            this.cmbItem.TabIndex = 100;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            this.cmbItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbItem_KeyPress);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "收入",
            "支出",
            "所有"});
            this.cmbType.Location = new System.Drawing.Point(101, 137);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(137, 29);
            this.cmbType.TabIndex = 99;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(21, 140);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(74, 21);
            this.lbType.TabIndex = 98;
            this.lbType.Text = "收支类别";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItem.ForeColor = System.Drawing.Color.White;
            this.lbItem.Location = new System.Drawing.Point(260, 140);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(74, 21);
            this.lbItem.TabIndex = 97;
            this.lbItem.Text = "收支项目";
            // 
            // lbStatisticsWay
            // 
            this.lbStatisticsWay.AutoSize = true;
            this.lbStatisticsWay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStatisticsWay.ForeColor = System.Drawing.Color.White;
            this.lbStatisticsWay.Location = new System.Drawing.Point(260, 88);
            this.lbStatisticsWay.Name = "lbStatisticsWay";
            this.lbStatisticsWay.Size = new System.Drawing.Size(74, 21);
            this.lbStatisticsWay.TabIndex = 101;
            this.lbStatisticsWay.Text = "统计方式";
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Location = new System.Drawing.Point(25, 195);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.RowTemplate.Height = 23;
            this.dgvStatistics.Size = new System.Drawing.Size(461, 142);
            this.dgvStatistics.TabIndex = 102;
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(25, 357);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(461, 62);
            this.lbTotal.TabIndex = 103;
            this.lbTotal.Text = "统计结果显示区";
            // 
            // TypeCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(515, 444);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dgvStatistics);
            this.Controls.Add(this.lbStatisticsWay);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.cmbWay);
            this.Controls.Add(this.dtpDateRange);
            this.Controls.Add(this.lbDataRange);
            this.Controls.Add(this.cmbRange);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypeCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收支类别统计情况";
            this.Load += new System.EventHandler(this.TypeCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRange;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbRange;
        private System.Windows.Forms.Label lbDataRange;
        private System.Windows.Forms.DateTimePicker dtpDateRange;
        private System.Windows.Forms.ComboBox cmbWay;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbStatisticsWay;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Label lbTotal;
    }
}