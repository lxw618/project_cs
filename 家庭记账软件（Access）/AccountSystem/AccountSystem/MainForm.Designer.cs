namespace AccountSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangeRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDayInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMonthInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFamilyInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangeInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSecondaryFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUseHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAppCaption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemFinance,
            this.MenuItemReport,
            this.MenuItemAccountAdmin,
            this.MenuItemSecondaryFunction,
            this.MenuItemHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(782, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChangePassword,
            this.MenuItemChangeUser,
            this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(44, 21);
            this.MenuItemFile.Text = "文件";
            // 
            // MenuItemChangePassword
            // 
            this.MenuItemChangePassword.Name = "MenuItemChangePassword";
            this.MenuItemChangePassword.Size = new System.Drawing.Size(124, 22);
            this.MenuItemChangePassword.Text = "密码重设";
            this.MenuItemChangePassword.Click += new System.EventHandler(this.MenuItemChangePassword_Click);
            // 
            // MenuItemChangeUser
            // 
            this.MenuItemChangeUser.Name = "MenuItemChangeUser";
            this.MenuItemChangeUser.Size = new System.Drawing.Size(124, 22);
            this.MenuItemChangeUser.Text = "切换账户";
            this.MenuItemChangeUser.Click += new System.EventHandler(this.MenuItemChangeUser_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(124, 22);
            this.MenuItemExit.Text = "退出";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemFinance
            // 
            this.MenuItemFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddRecord,
            this.MenuItemChangeRecord,
            this.MenuItemDeleteRecord});
            this.MenuItemFinance.Name = "MenuItemFinance";
            this.MenuItemFinance.Size = new System.Drawing.Size(44, 21);
            this.MenuItemFinance.Text = "财务";
            // 
            // MenuItemAddRecord
            // 
            this.MenuItemAddRecord.Name = "MenuItemAddRecord";
            this.MenuItemAddRecord.Size = new System.Drawing.Size(148, 22);
            this.MenuItemAddRecord.Text = "添加收支记录";
            this.MenuItemAddRecord.Click += new System.EventHandler(this.MenuItemAddRecord_Click);
            // 
            // MenuItemChangeRecord
            // 
            this.MenuItemChangeRecord.Name = "MenuItemChangeRecord";
            this.MenuItemChangeRecord.Size = new System.Drawing.Size(148, 22);
            this.MenuItemChangeRecord.Text = "修改收支记录";
            this.MenuItemChangeRecord.Click += new System.EventHandler(this.MenuItemChangeRecord_Click);
            // 
            // MenuItemDeleteRecord
            // 
            this.MenuItemDeleteRecord.Name = "MenuItemDeleteRecord";
            this.MenuItemDeleteRecord.Size = new System.Drawing.Size(148, 22);
            this.MenuItemDeleteRecord.Text = "删除收支记录";
            this.MenuItemDeleteRecord.Click += new System.EventHandler(this.MenuItemDeleteRecord_Click);
            // 
            // MenuItemReport
            // 
            this.MenuItemReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDayInstance,
            this.MenuItemMonthInstance,
            this.MenuItemFamilyInstance});
            this.MenuItemReport.Name = "MenuItemReport";
            this.MenuItemReport.Size = new System.Drawing.Size(44, 21);
            this.MenuItemReport.Text = "报表";
            // 
            // MenuItemDayInstance
            // 
            this.MenuItemDayInstance.Name = "MenuItemDayInstance";
            this.MenuItemDayInstance.Size = new System.Drawing.Size(196, 22);
            this.MenuItemDayInstance.Text = "当日收支情况";
            this.MenuItemDayInstance.Click += new System.EventHandler(this.MenuItemDayInstance_Click);
            // 
            // MenuItemMonthInstance
            // 
            this.MenuItemMonthInstance.Name = "MenuItemMonthInstance";
            this.MenuItemMonthInstance.Size = new System.Drawing.Size(196, 22);
            this.MenuItemMonthInstance.Text = "本月收支情况";
            this.MenuItemMonthInstance.Click += new System.EventHandler(this.MenuItemMonthInstance_Click);
            // 
            // MenuItemFamilyInstance
            // 
            this.MenuItemFamilyInstance.Name = "MenuItemFamilyInstance";
            this.MenuItemFamilyInstance.Size = new System.Drawing.Size(196, 22);
            this.MenuItemFamilyInstance.Text = "家庭年度收支情况统计";
            this.MenuItemFamilyInstance.Click += new System.EventHandler(this.MenuItemFamilyInstance_Click);
            // 
            // MenuItemAccountAdmin
            // 
            this.MenuItemAccountAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddAccount,
            this.MenuItemDeleteUser,
            this.MenuItemChangeInformation});
            this.MenuItemAccountAdmin.Name = "MenuItemAccountAdmin";
            this.MenuItemAccountAdmin.Size = new System.Drawing.Size(68, 21);
            this.MenuItemAccountAdmin.Text = "帐户管理";
            // 
            // MenuItemAddAccount
            // 
            this.MenuItemAddAccount.Name = "MenuItemAddAccount";
            this.MenuItemAddAccount.Size = new System.Drawing.Size(148, 22);
            this.MenuItemAddAccount.Text = "添加帐户";
            this.MenuItemAddAccount.Click += new System.EventHandler(this.MenuItemAddAccount_Click);
            // 
            // MenuItemDeleteUser
            // 
            this.MenuItemDeleteUser.Name = "MenuItemDeleteUser";
            this.MenuItemDeleteUser.Size = new System.Drawing.Size(148, 22);
            this.MenuItemDeleteUser.Text = "删除帐户";
            this.MenuItemDeleteUser.Click += new System.EventHandler(this.MenuItemDeleteUser_Click);
            // 
            // MenuItemChangeInformation
            // 
            this.MenuItemChangeInformation.Name = "MenuItemChangeInformation";
            this.MenuItemChangeInformation.Size = new System.Drawing.Size(148, 22);
            this.MenuItemChangeInformation.Text = "修改帐户信息";
            this.MenuItemChangeInformation.Click += new System.EventHandler(this.MenuItemChangeInformation_Click);
            // 
            // MenuItemSecondaryFunction
            // 
            this.MenuItemSecondaryFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCalc,
            this.MenuItemCalendar});
            this.MenuItemSecondaryFunction.Name = "MenuItemSecondaryFunction";
            this.MenuItemSecondaryFunction.Size = new System.Drawing.Size(68, 21);
            this.MenuItemSecondaryFunction.Text = "辅助功能";
            // 
            // MenuItemCalc
            // 
            this.MenuItemCalc.Name = "MenuItemCalc";
            this.MenuItemCalc.Size = new System.Drawing.Size(112, 22);
            this.MenuItemCalc.Text = "计算器";
            this.MenuItemCalc.Click += new System.EventHandler(this.MenuItemCalc_Click);
            // 
            // MenuItemCalendar
            // 
            this.MenuItemCalendar.Name = "MenuItemCalendar";
            this.MenuItemCalendar.Size = new System.Drawing.Size(112, 22);
            this.MenuItemCalendar.Text = "日历";
            this.MenuItemCalendar.Click += new System.EventHandler(this.MenuItemCalendar_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUseHelp,
            this.MenuItemAppCaption});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 21);
            this.MenuItemHelp.Text = "帮助";
            // 
            // MenuItemUseHelp
            // 
            this.MenuItemUseHelp.Name = "MenuItemUseHelp";
            this.MenuItemUseHelp.Size = new System.Drawing.Size(124, 22);
            this.MenuItemUseHelp.Text = "使用说明";
            this.MenuItemUseHelp.Click += new System.EventHandler(this.MenuItemUseHelp_Click);
            // 
            // MenuItemAppCaption
            // 
            this.MenuItemAppCaption.Name = "MenuItemAppCaption";
            this.MenuItemAppCaption.Size = new System.Drawing.Size(124, 22);
            this.MenuItemAppCaption.Text = "程序说明";
            this.MenuItemAppCaption.Click += new System.EventHandler(this.MenuItemAppCaption_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::AccountSystem.Properties.Resources._10010_12040510501883;
            this.ClientSize = new System.Drawing.Size(782, 475);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "家庭记账软件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFinance;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReport;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountAdmin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSecondaryFunction;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDayInstance;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFamilyInstance;
        public System.Windows.Forms.ToolStripMenuItem MenuItemDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCalc;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangeRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMonthInstance;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangeUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangeInformation;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUseHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAppCaption;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCalendar;
    }
}