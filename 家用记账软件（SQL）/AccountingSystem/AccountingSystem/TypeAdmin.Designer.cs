namespace AccountingSystem
{
    partial class TypeAdmin
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
            this.lbIncomeType = new System.Windows.Forms.Label();
            this.lbOutcomeType = new System.Windows.Forms.Label();
            this.listIncomeType = new System.Windows.Forms.ListBox();
            this.listOutcomeType = new System.Windows.Forms.ListBox();
            this.cmbTypeAdd = new System.Windows.Forms.ComboBox();
            this.cmbTypeDelete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbDeleteItem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbIncomeType
            // 
            this.lbIncomeType.AutoSize = true;
            this.lbIncomeType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIncomeType.ForeColor = System.Drawing.Color.White;
            this.lbIncomeType.Location = new System.Drawing.Point(32, 32);
            this.lbIncomeType.Name = "lbIncomeType";
            this.lbIncomeType.Size = new System.Drawing.Size(74, 21);
            this.lbIncomeType.TabIndex = 0;
            this.lbIncomeType.Text = "收入类型";
            // 
            // lbOutcomeType
            // 
            this.lbOutcomeType.AutoSize = true;
            this.lbOutcomeType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOutcomeType.ForeColor = System.Drawing.Color.White;
            this.lbOutcomeType.Location = new System.Drawing.Point(257, 32);
            this.lbOutcomeType.Name = "lbOutcomeType";
            this.lbOutcomeType.Size = new System.Drawing.Size(74, 21);
            this.lbOutcomeType.TabIndex = 1;
            this.lbOutcomeType.Text = "支出类型";
            // 
            // listIncomeType
            // 
            this.listIncomeType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listIncomeType.FormattingEnabled = true;
            this.listIncomeType.ItemHeight = 21;
            this.listIncomeType.Location = new System.Drawing.Point(36, 69);
            this.listIncomeType.Name = "listIncomeType";
            this.listIncomeType.Size = new System.Drawing.Size(179, 130);
            this.listIncomeType.TabIndex = 2;
            // 
            // listOutcomeType
            // 
            this.listOutcomeType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listOutcomeType.FormattingEnabled = true;
            this.listOutcomeType.ItemHeight = 21;
            this.listOutcomeType.Location = new System.Drawing.Point(261, 69);
            this.listOutcomeType.Name = "listOutcomeType";
            this.listOutcomeType.Size = new System.Drawing.Size(180, 130);
            this.listOutcomeType.TabIndex = 3;
            // 
            // cmbTypeAdd
            // 
            this.cmbTypeAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTypeAdd.FormattingEnabled = true;
            this.cmbTypeAdd.Items.AddRange(new object[] {
            "收入",
            "支出"});
            this.cmbTypeAdd.Location = new System.Drawing.Point(36, 258);
            this.cmbTypeAdd.Name = "cmbTypeAdd";
            this.cmbTypeAdd.Size = new System.Drawing.Size(154, 29);
            this.cmbTypeAdd.TabIndex = 40;
            // 
            // cmbTypeDelete
            // 
            this.cmbTypeDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTypeDelete.FormattingEnabled = true;
            this.cmbTypeDelete.Items.AddRange(new object[] {
            "收入",
            "支出"});
            this.cmbTypeDelete.Location = new System.Drawing.Point(36, 335);
            this.cmbTypeDelete.Name = "cmbTypeDelete";
            this.cmbTypeDelete.Size = new System.Drawing.Size(154, 29);
            this.cmbTypeDelete.TabIndex = 41;
            this.cmbTypeDelete.SelectedValueChanged += new System.EventHandler(this.cmbTypeDelete_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "增加";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "删除";
            // 
            // txtAddItem
            // 
            this.txtAddItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddItem.Location = new System.Drawing.Point(208, 258);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(137, 29);
            this.txtAddItem.TabIndex = 44;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(366, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(366, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbDeleteItem
            // 
            this.cmbDeleteItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDeleteItem.FormattingEnabled = true;
            this.cmbDeleteItem.Location = new System.Drawing.Point(208, 334);
            this.cmbDeleteItem.Name = "cmbDeleteItem";
            this.cmbDeleteItem.Size = new System.Drawing.Size(137, 29);
            this.cmbDeleteItem.TabIndex = 48;
            // 
            // TypeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(493, 411);
            this.Controls.Add(this.cmbDeleteItem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTypeDelete);
            this.Controls.Add(this.cmbTypeAdd);
            this.Controls.Add(this.listOutcomeType);
            this.Controls.Add(this.listIncomeType);
            this.Controls.Add(this.lbOutcomeType);
            this.Controls.Add(this.lbIncomeType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理收支类型";
            this.Load += new System.EventHandler(this.TypeAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIncomeType;
        private System.Windows.Forms.Label lbOutcomeType;
        private System.Windows.Forms.ListBox listIncomeType;
        private System.Windows.Forms.ListBox listOutcomeType;
        private System.Windows.Forms.ComboBox cmbTypeAdd;
        private System.Windows.Forms.ComboBox cmbTypeDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbDeleteItem;
    }
}