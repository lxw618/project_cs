namespace AccountingSystem
{
    partial class ExchangeRateSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeRateSet));
            this.lbTitle = new System.Windows.Forms.Label();
            this.cmbAfter = new System.Windows.Forms.ComboBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbOriginalOne = new System.Windows.Forms.Label();
            this.lbUSD = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(12, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(133, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "汇率设定";
            // 
            // cmbAfter
            // 
            this.cmbAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAfter.FormattingEnabled = true;
            this.cmbAfter.Items.AddRange(new object[] {
            "人民币CNY",
            "欧元EUR",
            "英镑GBP",
            "澳元AUD",
            "日元JPY"});
            this.cmbAfter.Location = new System.Drawing.Point(246, 123);
            this.cmbAfter.Name = "cmbAfter";
            this.cmbAfter.Size = new System.Drawing.Size(121, 29);
            this.cmbAfter.TabIndex = 30;
            this.cmbAfter.SelectedIndexChanged += new System.EventHandler(this.cmbAfter_SelectedIndexChanged);
            // 
            // txtAfter
            // 
            this.txtAfter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAfter.Location = new System.Drawing.Point(115, 123);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(110, 29);
            this.txtAfter.TabIndex = 31;
            this.txtAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAfter_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "兑换前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "兑换后";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(201)))), ((int)(((byte)(100)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(165, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "保存设定";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbOriginalOne
            // 
            this.lbOriginalOne.AutoSize = true;
            this.lbOriginalOne.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOriginalOne.ForeColor = System.Drawing.Color.White;
            this.lbOriginalOne.Location = new System.Drawing.Point(206, 84);
            this.lbOriginalOne.Name = "lbOriginalOne";
            this.lbOriginalOne.Size = new System.Drawing.Size(19, 21);
            this.lbOriginalOne.TabIndex = 40;
            this.lbOriginalOne.Text = "1";
            // 
            // lbUSD
            // 
            this.lbUSD.AutoSize = true;
            this.lbUSD.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUSD.ForeColor = System.Drawing.Color.White;
            this.lbUSD.Location = new System.Drawing.Point(292, 84);
            this.lbUSD.Name = "lbUSD";
            this.lbUSD.Size = new System.Drawing.Size(75, 21);
            this.lbUSD.TabIndex = 41;
            this.lbUSD.Text = "美元USD";
            // 
            // picClose
            // 
            this.picClose.Image = global::AccountingSystem.Properties.Resources.Close1;
            this.picClose.Location = new System.Drawing.Point(356, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(39, 42);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 27;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            // 
            // ExchangeRateSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(178)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(407, 223);
            this.Controls.Add(this.lbUSD);
            this.Controls.Add(this.lbOriginalOne);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.cmbAfter);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExchangeRateSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汇率设定";
            this.Load += new System.EventHandler(this.ExchangeRateSet_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExchangeRateSet_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExchangeRateSet_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.ComboBox cmbAfter;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbOriginalOne;
        private System.Windows.Forms.Label lbUSD;
    }
}