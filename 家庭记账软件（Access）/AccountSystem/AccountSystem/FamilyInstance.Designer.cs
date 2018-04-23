namespace AccountSystem
{
    partial class FamilyInstance
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
            this.tcFamilyInstance = new System.Windows.Forms.TabControl();
            this.tpFamilyYear = new System.Windows.Forms.TabPage();
            this.dgvFamilyYear = new System.Windows.Forms.DataGridView();
            this.tpFamilyIn = new System.Windows.Forms.TabPage();
            this.dgvIn = new System.Windows.Forms.DataGridView();
            this.tpFamilyOut = new System.Windows.Forms.TabPage();
            this.dgvOut = new System.Windows.Forms.DataGridView();
            this.tpFamilyAll = new System.Windows.Forms.TabPage();
            this.lbGet = new System.Windows.Forms.Label();
            this.lbOutcome = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.listOutcomeItem = new System.Windows.Forms.ListBox();
            this.listIncomeItem = new System.Windows.Forms.ListBox();
            this.lbOutcomeItem = new System.Windows.Forms.Label();
            this.lbIncomeItem = new System.Windows.Forms.Label();
            this.btnFresh = new System.Windows.Forms.Button();
            this.tcFamilyInstance.SuspendLayout();
            this.tpFamilyYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyYear)).BeginInit();
            this.tpFamilyIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
            this.tpFamilyOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).BeginInit();
            this.tpFamilyAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFamilyInstance
            // 
            this.tcFamilyInstance.Controls.Add(this.tpFamilyYear);
            this.tcFamilyInstance.Controls.Add(this.tpFamilyIn);
            this.tcFamilyInstance.Controls.Add(this.tpFamilyOut);
            this.tcFamilyInstance.Controls.Add(this.tpFamilyAll);
            this.tcFamilyInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFamilyInstance.Location = new System.Drawing.Point(0, 0);
            this.tcFamilyInstance.Name = "tcFamilyInstance";
            this.tcFamilyInstance.SelectedIndex = 0;
            this.tcFamilyInstance.Size = new System.Drawing.Size(675, 410);
            this.tcFamilyInstance.TabIndex = 0;
            // 
            // tpFamilyYear
            // 
            this.tpFamilyYear.Controls.Add(this.dgvFamilyYear);
            this.tpFamilyYear.Location = new System.Drawing.Point(4, 22);
            this.tpFamilyYear.Name = "tpFamilyYear";
            this.tpFamilyYear.Padding = new System.Windows.Forms.Padding(3);
            this.tpFamilyYear.Size = new System.Drawing.Size(667, 384);
            this.tpFamilyYear.TabIndex = 0;
            this.tpFamilyYear.Text = "家庭年度收支情况总览";
            this.tpFamilyYear.UseVisualStyleBackColor = true;
            // 
            // dgvFamilyYear
            // 
            this.dgvFamilyYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilyYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFamilyYear.Location = new System.Drawing.Point(3, 3);
            this.dgvFamilyYear.Name = "dgvFamilyYear";
            this.dgvFamilyYear.ReadOnly = true;
            this.dgvFamilyYear.RowTemplate.Height = 23;
            this.dgvFamilyYear.Size = new System.Drawing.Size(661, 378);
            this.dgvFamilyYear.TabIndex = 0;
            // 
            // tpFamilyIn
            // 
            this.tpFamilyIn.Controls.Add(this.dgvIn);
            this.tpFamilyIn.Location = new System.Drawing.Point(4, 22);
            this.tpFamilyIn.Name = "tpFamilyIn";
            this.tpFamilyIn.Padding = new System.Windows.Forms.Padding(3);
            this.tpFamilyIn.Size = new System.Drawing.Size(667, 384);
            this.tpFamilyIn.TabIndex = 2;
            this.tpFamilyIn.Text = "家庭年度收入情况总览";
            this.tpFamilyIn.UseVisualStyleBackColor = true;
            // 
            // dgvIn
            // 
            this.dgvIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIn.Location = new System.Drawing.Point(3, 3);
            this.dgvIn.Name = "dgvIn";
            this.dgvIn.ReadOnly = true;
            this.dgvIn.RowTemplate.Height = 23;
            this.dgvIn.Size = new System.Drawing.Size(661, 378);
            this.dgvIn.TabIndex = 0;
            // 
            // tpFamilyOut
            // 
            this.tpFamilyOut.Controls.Add(this.dgvOut);
            this.tpFamilyOut.Location = new System.Drawing.Point(4, 22);
            this.tpFamilyOut.Name = "tpFamilyOut";
            this.tpFamilyOut.Padding = new System.Windows.Forms.Padding(3);
            this.tpFamilyOut.Size = new System.Drawing.Size(667, 384);
            this.tpFamilyOut.TabIndex = 3;
            this.tpFamilyOut.Text = "家庭年度支出情况总览";
            this.tpFamilyOut.UseVisualStyleBackColor = true;
            // 
            // dgvOut
            // 
            this.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOut.Location = new System.Drawing.Point(3, 3);
            this.dgvOut.Name = "dgvOut";
            this.dgvOut.ReadOnly = true;
            this.dgvOut.RowTemplate.Height = 23;
            this.dgvOut.Size = new System.Drawing.Size(661, 378);
            this.dgvOut.TabIndex = 0;
            // 
            // tpFamilyAll
            // 
            this.tpFamilyAll.Controls.Add(this.btnFresh);
            this.tpFamilyAll.Controls.Add(this.lbGet);
            this.tpFamilyAll.Controls.Add(this.lbOutcome);
            this.tpFamilyAll.Controls.Add(this.lbIncome);
            this.tpFamilyAll.Controls.Add(this.lb3);
            this.tpFamilyAll.Controls.Add(this.lb2);
            this.tpFamilyAll.Controls.Add(this.lb1);
            this.tpFamilyAll.Controls.Add(this.listOutcomeItem);
            this.tpFamilyAll.Controls.Add(this.listIncomeItem);
            this.tpFamilyAll.Controls.Add(this.lbOutcomeItem);
            this.tpFamilyAll.Controls.Add(this.lbIncomeItem);
            this.tpFamilyAll.Location = new System.Drawing.Point(4, 22);
            this.tpFamilyAll.Name = "tpFamilyAll";
            this.tpFamilyAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpFamilyAll.Size = new System.Drawing.Size(667, 384);
            this.tpFamilyAll.TabIndex = 1;
            this.tpFamilyAll.Text = "家庭年度收支情况统计";
            this.tpFamilyAll.UseVisualStyleBackColor = true;
            // 
            // lbGet
            // 
            this.lbGet.AutoSize = true;
            this.lbGet.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.lbGet.Location = new System.Drawing.Point(150, 334);
            this.lbGet.Name = "lbGet";
            this.lbGet.Size = new System.Drawing.Size(42, 25);
            this.lbGet.TabIndex = 9;
            this.lbGet.Text = "0元";
            // 
            // lbOutcome
            // 
            this.lbOutcome.AutoSize = true;
            this.lbOutcome.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.lbOutcome.Location = new System.Drawing.Point(150, 285);
            this.lbOutcome.Name = "lbOutcome";
            this.lbOutcome.Size = new System.Drawing.Size(42, 25);
            this.lbOutcome.TabIndex = 8;
            this.lbOutcome.Text = "0元";
            // 
            // lbIncome
            // 
            this.lbIncome.AutoSize = true;
            this.lbIncome.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.lbIncome.Location = new System.Drawing.Point(150, 236);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(42, 25);
            this.lbIncome.TabIndex = 7;
            this.lbIncome.Text = "0元";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.lb3.Location = new System.Drawing.Point(29, 334);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(88, 25);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "年度盈余";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.lb2.Location = new System.Drawing.Point(29, 285);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(107, 25);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "年度总支出";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.lb1.Location = new System.Drawing.Point(29, 236);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(107, 25);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "年度总收入";
            // 
            // listOutcomeItem
            // 
            this.listOutcomeItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listOutcomeItem.FormattingEnabled = true;
            this.listOutcomeItem.ItemHeight = 21;
            this.listOutcomeItem.Location = new System.Drawing.Point(353, 53);
            this.listOutcomeItem.Name = "listOutcomeItem";
            this.listOutcomeItem.Size = new System.Drawing.Size(251, 151);
            this.listOutcomeItem.TabIndex = 3;
            // 
            // listIncomeItem
            // 
            this.listIncomeItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listIncomeItem.FormattingEnabled = true;
            this.listIncomeItem.ItemHeight = 21;
            this.listIncomeItem.Location = new System.Drawing.Point(34, 53);
            this.listIncomeItem.Name = "listIncomeItem";
            this.listIncomeItem.Size = new System.Drawing.Size(251, 151);
            this.listIncomeItem.TabIndex = 2;
            // 
            // lbOutcomeItem
            // 
            this.lbOutcomeItem.AutoSize = true;
            this.lbOutcomeItem.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOutcomeItem.Location = new System.Drawing.Point(351, 28);
            this.lbOutcomeItem.Name = "lbOutcomeItem";
            this.lbOutcomeItem.Size = new System.Drawing.Size(126, 26);
            this.lbOutcomeItem.TabIndex = 1;
            this.lbOutcomeItem.Text = "年度支出项目";
            // 
            // lbIncomeItem
            // 
            this.lbIncomeItem.AutoSize = true;
            this.lbIncomeItem.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIncomeItem.Location = new System.Drawing.Point(32, 28);
            this.lbIncomeItem.Name = "lbIncomeItem";
            this.lbIncomeItem.Size = new System.Drawing.Size(126, 26);
            this.lbIncomeItem.TabIndex = 0;
            this.lbIncomeItem.Text = "年度收入项目";
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.Black;
            this.btnFresh.FlatAppearance.BorderSize = 0;
            this.btnFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresh.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFresh.ForeColor = System.Drawing.Color.White;
            this.btnFresh.Location = new System.Drawing.Point(501, 277);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(103, 33);
            this.btnFresh.TabIndex = 109;
            this.btnFresh.Text = "刷新数据";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // FamilyInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(675, 410);
            this.Controls.Add(this.tcFamilyInstance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FamilyInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家庭年度收支情况统计";
            this.Load += new System.EventHandler(this.FamilyInstance_Load);
            this.tcFamilyInstance.ResumeLayout(false);
            this.tpFamilyYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyYear)).EndInit();
            this.tpFamilyIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
            this.tpFamilyOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).EndInit();
            this.tpFamilyAll.ResumeLayout(false);
            this.tpFamilyAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFamilyInstance;
        private System.Windows.Forms.TabPage tpFamilyYear;
        private System.Windows.Forms.TabPage tpFamilyAll;
        private System.Windows.Forms.DataGridView dgvFamilyYear;
        private System.Windows.Forms.TabPage tpFamilyIn;
        private System.Windows.Forms.DataGridView dgvIn;
        private System.Windows.Forms.TabPage tpFamilyOut;
        private System.Windows.Forms.DataGridView dgvOut;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ListBox listOutcomeItem;
        private System.Windows.Forms.ListBox listIncomeItem;
        private System.Windows.Forms.Label lbOutcomeItem;
        private System.Windows.Forms.Label lbIncomeItem;
        private System.Windows.Forms.Label lbGet;
        private System.Windows.Forms.Label lbOutcome;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.Button btnFresh;
    }
}