namespace AccountingSystem
{
    partial class ExchangeRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeRate));
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.cmbOriginal = new System.Windows.Forms.ComboBox();
            this.cmbAfter = new System.Windows.Forms.ComboBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
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
            this.lbTitle.Text = "汇率换算";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOriginal.Location = new System.Drawing.Point(115, 81);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(110, 29);
            this.txtOriginal.TabIndex = 28;
            this.txtOriginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOriginal_KeyPress);
            // 
            // cmbOriginal
            // 
            this.cmbOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOriginal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbOriginal.FormattingEnabled = true;
            this.cmbOriginal.Items.AddRange(new object[] {
            "人民币CNY",
            "美元USD",
            "欧元EUR",
            "英镑GBP",
            "澳元AUD",
            "日元JPY"});
            this.cmbOriginal.Location = new System.Drawing.Point(246, 81);
            this.cmbOriginal.Name = "cmbOriginal";
            this.cmbOriginal.Size = new System.Drawing.Size(121, 29);
            this.cmbOriginal.TabIndex = 29;
            // 
            // cmbAfter
            // 
            this.cmbAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAfter.FormattingEnabled = true;
            this.cmbAfter.Items.AddRange(new object[] {
            "美元USD",
            "人民币CNY",
            "欧元EUR",
            "英镑GBP",
            "澳元AUD",
            "日元JPY"});
            this.cmbAfter.Location = new System.Drawing.Point(246, 147);
            this.cmbAfter.Name = "cmbAfter";
            this.cmbAfter.Size = new System.Drawing.Size(121, 29);
            this.cmbAfter.TabIndex = 30;
            // 
            // txtAfter
            // 
            this.txtAfter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAfter.Location = new System.Drawing.Point(115, 147);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.ReadOnly = true;
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
            this.label2.Location = new System.Drawing.Point(37, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "兑换后";
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(201)))), ((int)(((byte)(100)))));
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(115, 210);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(87, 28);
            this.btnSet.TabIndex = 39;
            this.btnSet.Text = "汇率设定";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(201)))), ((int)(((byte)(100)))));
            this.btnExchange.FlatAppearance.BorderSize = 0;
            this.btnExchange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnExchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExchange.ForeColor = System.Drawing.Color.White;
            this.btnExchange.Location = new System.Drawing.Point(222, 210);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(87, 28);
            this.btnExchange.TabIndex = 38;
            this.btnExchange.Text = "转换";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
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
            // ExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(172)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(407, 260);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.cmbAfter);
            this.Controls.Add(this.cmbOriginal);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExchangeRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汇率换算";
            this.Load += new System.EventHandler(this.ExchangeRate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExchangeRate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExchangeRate_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.ComboBox cmbOriginal;
        private System.Windows.Forms.ComboBox cmbAfter;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnExchange;
    }
}