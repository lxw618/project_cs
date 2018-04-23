namespace calculate
{
    partial class calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calc));
            this.result = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.closetransp = new System.Windows.Forms.PictureBox();
            this.closered = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.one = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.fma = new System.Windows.Forms.Button();
            this.bma = new System.Windows.Forms.Button();
            this.yma = new System.Windows.Forms.Button();
            this.lbStatic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closetransp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(106, 72);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(283, 39);
            this.result.TabIndex = 1;
            this.result.TabStop = false;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(160, 46);
            this.title.TabIndex = 0;
            this.title.Text = "三码转换";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // closetransp
            // 
            this.closetransp.Image = global::calculate.Properties.Resources.关闭;
            this.closetransp.Location = new System.Drawing.Point(301, 12);
            this.closetransp.Name = "closetransp";
            this.closetransp.Size = new System.Drawing.Size(41, 41);
            this.closetransp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closetransp.TabIndex = 24;
            this.closetransp.TabStop = false;
            this.closetransp.Visible = false;
            // 
            // closered
            // 
            this.closered.Image = global::calculate.Properties.Resources.关闭1;
            this.closered.Location = new System.Drawing.Point(253, 13);
            this.closered.Name = "closered";
            this.closered.Size = new System.Drawing.Size(41, 41);
            this.closered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closered.TabIndex = 23;
            this.closered.TabStop = false;
            this.closered.Visible = false;
            // 
            // close
            // 
            this.close.Image = global::calculate.Properties.Resources.关闭;
            this.close.Location = new System.Drawing.Point(348, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 42);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 22;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.one.ForeColor = System.Drawing.Color.White;
            this.one.Location = new System.Drawing.Point(19, 136);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(87, 56);
            this.one.TabIndex = 10;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CE.FlatAppearance.BorderSize = 0;
            this.CE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CE.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CE.ForeColor = System.Drawing.Color.White;
            this.CE.Location = new System.Drawing.Point(207, 136);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(87, 56);
            this.CE.TabIndex = 14;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zero.ForeColor = System.Drawing.Color.White;
            this.zero.Location = new System.Drawing.Point(113, 136);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(87, 56);
            this.zero.TabIndex = 15;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backspace.ForeColor = System.Drawing.Color.White;
            this.backspace.Location = new System.Drawing.Point(301, 136);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(88, 56);
            this.backspace.TabIndex = 18;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMove.ForeColor = System.Drawing.Color.White;
            this.btnMove.Location = new System.Drawing.Point(302, 208);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(88, 56);
            this.btnMove.TabIndex = 28;
            this.btnMove.Text = "←→";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // fma
            // 
            this.fma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.fma.FlatAppearance.BorderSize = 0;
            this.fma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fma.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fma.ForeColor = System.Drawing.Color.White;
            this.fma.Location = new System.Drawing.Point(113, 208);
            this.fma.Name = "fma";
            this.fma.Size = new System.Drawing.Size(87, 56);
            this.fma.TabIndex = 27;
            this.fma.Text = "反码";
            this.fma.UseVisualStyleBackColor = false;
            this.fma.Click += new System.EventHandler(this.fma_Click);
            // 
            // bma
            // 
            this.bma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bma.FlatAppearance.BorderSize = 0;
            this.bma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bma.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bma.ForeColor = System.Drawing.Color.White;
            this.bma.Location = new System.Drawing.Point(207, 208);
            this.bma.Name = "bma";
            this.bma.Size = new System.Drawing.Size(88, 56);
            this.bma.TabIndex = 26;
            this.bma.Text = "补码";
            this.bma.UseVisualStyleBackColor = false;
            this.bma.Click += new System.EventHandler(this.bma_Click);
            // 
            // yma
            // 
            this.yma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.yma.FlatAppearance.BorderSize = 0;
            this.yma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.yma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yma.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yma.ForeColor = System.Drawing.Color.White;
            this.yma.Location = new System.Drawing.Point(19, 208);
            this.yma.Name = "yma";
            this.yma.Size = new System.Drawing.Size(87, 56);
            this.yma.TabIndex = 25;
            this.yma.Text = "原码";
            this.yma.UseVisualStyleBackColor = false;
            this.yma.Click += new System.EventHandler(this.yma_Click);
            // 
            // lbStatic
            // 
            this.lbStatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbStatic.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStatic.ForeColor = System.Drawing.Color.White;
            this.lbStatic.Location = new System.Drawing.Point(20, 72);
            this.lbStatic.Name = "lbStatic";
            this.lbStatic.Size = new System.Drawing.Size(86, 39);
            this.lbStatic.TabIndex = 29;
            this.lbStatic.Text = "原码";
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(9)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(407, 283);
            this.Controls.Add(this.lbStatic);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.fma);
            this.Controls.Add(this.bma);
            this.Controls.Add(this.yma);
            this.Controls.Add(this.closetransp);
            this.Controls.Add(this.closered);
            this.Controls.Add(this.close);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.one);
            this.Controls.Add(this.title);
            this.Controls.Add(this.result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.calc_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calc_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.calc_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.closetransp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox closetransp;
        private System.Windows.Forms.PictureBox closered;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button fma;
        private System.Windows.Forms.Button bma;
        private System.Windows.Forms.Button yma;
        private System.Windows.Forms.Label lbStatic;
    }
}

