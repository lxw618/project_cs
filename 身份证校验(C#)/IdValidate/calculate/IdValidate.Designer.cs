namespace calculate
{
    partial class IdValidate
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdValidate));
            this.txtId = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lbStatic = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeState = new System.Windows.Forms.Label();
            this.lblSexState = new System.Windows.Forms.Label();
            this.lblDateState = new System.Windows.Forms.Label();
            this.lblLocationState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(31)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtId.Location = new System.Drawing.Point(117, 71);
            this.txtId.MaxLength = 18;
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.Size = new System.Drawing.Size(271, 28);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(230, 46);
            this.title.TabIndex = 0;
            this.title.Text = "身份证号校验";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // close
            // 
            this.close.Image = global::calculate.Properties.Resources.关闭;
            this.close.Location = new System.Drawing.Point(348, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 22;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            // 
            // btnValidate
            // 
            this.btnValidate.AutoSize = true;
            this.btnValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(31)))));
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.btnValidate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(165, 240);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(87, 31);
            this.btnValidate.TabIndex = 10;
            this.btnValidate.Text = "校验";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lbStatic
            // 
            this.lbStatic.AutoSize = true;
            this.lbStatic.BackColor = System.Drawing.Color.Transparent;
            this.lbStatic.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStatic.ForeColor = System.Drawing.Color.White;
            this.lbStatic.Location = new System.Drawing.Point(19, 72);
            this.lbStatic.Name = "lbStatic";
            this.lbStatic.Size = new System.Drawing.Size(92, 27);
            this.lbStatic.TabIndex = 29;
            this.lbStatic.Text = "身份证号";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(19, 111);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(72, 27);
            this.lblLocation.TabIndex = 30;
            this.lblLocation.Text = "注册地";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(19, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 27);
            this.lblDate.TabIndex = 31;
            this.lblDate.Text = "出生日期";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(19, 169);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(52, 27);
            this.lblSex.TabIndex = 32;
            this.lblSex.Text = "性别";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(19, 197);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(52, 27);
            this.lblAge.TabIndex = 33;
            this.lblAge.Text = "年龄";
            // 
            // lblAgeState
            // 
            this.lblAgeState.AutoSize = true;
            this.lblAgeState.BackColor = System.Drawing.Color.Transparent;
            this.lblAgeState.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAgeState.ForeColor = System.Drawing.Color.White;
            this.lblAgeState.Location = new System.Drawing.Point(117, 197);
            this.lblAgeState.Name = "lblAgeState";
            this.lblAgeState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAgeState.Size = new System.Drawing.Size(92, 27);
            this.lblAgeState.TabIndex = 37;
            this.lblAgeState.Text = "暂无信息";
            // 
            // lblSexState
            // 
            this.lblSexState.AutoSize = true;
            this.lblSexState.BackColor = System.Drawing.Color.Transparent;
            this.lblSexState.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSexState.ForeColor = System.Drawing.Color.White;
            this.lblSexState.Location = new System.Drawing.Point(117, 169);
            this.lblSexState.Name = "lblSexState";
            this.lblSexState.Size = new System.Drawing.Size(92, 27);
            this.lblSexState.TabIndex = 36;
            this.lblSexState.Text = "暂无信息";
            // 
            // lblDateState
            // 
            this.lblDateState.AutoSize = true;
            this.lblDateState.BackColor = System.Drawing.Color.Transparent;
            this.lblDateState.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDateState.ForeColor = System.Drawing.Color.White;
            this.lblDateState.Location = new System.Drawing.Point(117, 141);
            this.lblDateState.Name = "lblDateState";
            this.lblDateState.Size = new System.Drawing.Size(92, 27);
            this.lblDateState.TabIndex = 35;
            this.lblDateState.Text = "暂无信息";
            // 
            // lblLocationState
            // 
            this.lblLocationState.AutoSize = true;
            this.lblLocationState.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationState.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLocationState.ForeColor = System.Drawing.Color.White;
            this.lblLocationState.Location = new System.Drawing.Point(117, 111);
            this.lblLocationState.Name = "lblLocationState";
            this.lblLocationState.Size = new System.Drawing.Size(92, 27);
            this.lblLocationState.TabIndex = 34;
            this.lblLocationState.Text = "暂无信息";
            // 
            // IdValidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(179)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(407, 283);
            this.Controls.Add(this.lblAgeState);
            this.Controls.Add(this.lblSexState);
            this.Controls.Add(this.lblDateState);
            this.Controls.Add(this.lblLocationState);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lbStatic);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.title);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IdValidate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "身份证号校验";
            this.Load += new System.EventHandler(this.calc_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calc_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.calc_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lbStatic;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeState;
        private System.Windows.Forms.Label lblSexState;
        private System.Windows.Forms.Label lblDateState;
        private System.Windows.Forms.Label lblLocationState;
    }
}

