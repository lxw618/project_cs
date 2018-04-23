namespace AccountingSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.MenuItemOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangeRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTypeAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEveryDayCase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEveryMonthCase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEveryYearCase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTypeCase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangeUserInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOtherFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExchangeRate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMail = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOption = new System.Windows.Forms.ToolStrip();
            this.StripButtonSwitchUser = new System.Windows.Forms.ToolStripButton();
            this.StripButtonAddRecord = new System.Windows.Forms.ToolStripButton();
            this.StripButtonCalc = new System.Windows.Forms.ToolStripButton();
            this.StripButtonCalendar = new System.Windows.Forms.ToolStripButton();
            this.StripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.StripButtonSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.toolStripOption.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOption,
            this.MenuItemFinance,
            this.MenuItemReport,
            this.MenuItemAccountManage,
            this.MenuItemOtherFunction,
            this.MenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1159, 25);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "菜单";
            // 
            // MenuItemOption
            // 
            this.MenuItemOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChangePassword,
            this.MenuItemChangeUser,
            this.MenuItemExit});
            this.MenuItemOption.Name = "MenuItemOption";
            this.MenuItemOption.Size = new System.Drawing.Size(44, 21);
            this.MenuItemOption.Text = "选项";
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
            this.MenuItemDeleteRecord,
            this.MenuItemChangeRecord,
            this.MenuItemTypeAdmin});
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
            // MenuItemDeleteRecord
            // 
            this.MenuItemDeleteRecord.Name = "MenuItemDeleteRecord";
            this.MenuItemDeleteRecord.Size = new System.Drawing.Size(148, 22);
            this.MenuItemDeleteRecord.Text = "删除收支记录";
            this.MenuItemDeleteRecord.Click += new System.EventHandler(this.MenuItemDeleteRecord_Click);
            // 
            // MenuItemChangeRecord
            // 
            this.MenuItemChangeRecord.Name = "MenuItemChangeRecord";
            this.MenuItemChangeRecord.Size = new System.Drawing.Size(148, 22);
            this.MenuItemChangeRecord.Text = "修改收支记录";
            this.MenuItemChangeRecord.Click += new System.EventHandler(this.MenuItemChangeRecord_Click);
            // 
            // MenuItemTypeAdmin
            // 
            this.MenuItemTypeAdmin.Name = "MenuItemTypeAdmin";
            this.MenuItemTypeAdmin.Size = new System.Drawing.Size(148, 22);
            this.MenuItemTypeAdmin.Text = "管理收支类型";
            this.MenuItemTypeAdmin.Click += new System.EventHandler(this.MenuItemTypeAdmin_Click);
            // 
            // MenuItemReport
            // 
            this.MenuItemReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEveryDayCase,
            this.MenuItemEveryMonthCase,
            this.MenuItemEveryYearCase,
            this.MenuItemTypeCase});
            this.MenuItemReport.Name = "MenuItemReport";
            this.MenuItemReport.Size = new System.Drawing.Size(44, 21);
            this.MenuItemReport.Text = "报表";
            // 
            // MenuItemEveryDayCase
            // 
            this.MenuItemEveryDayCase.Name = "MenuItemEveryDayCase";
            this.MenuItemEveryDayCase.Size = new System.Drawing.Size(172, 22);
            this.MenuItemEveryDayCase.Text = "每日收支情况";
            this.MenuItemEveryDayCase.Click += new System.EventHandler(this.MenuItemEveryDayCase_Click);
            // 
            // MenuItemEveryMonthCase
            // 
            this.MenuItemEveryMonthCase.Name = "MenuItemEveryMonthCase";
            this.MenuItemEveryMonthCase.Size = new System.Drawing.Size(172, 22);
            this.MenuItemEveryMonthCase.Text = "每月收支情况";
            this.MenuItemEveryMonthCase.Click += new System.EventHandler(this.MenuItemEveryMonthCase_Click);
            // 
            // MenuItemEveryYearCase
            // 
            this.MenuItemEveryYearCase.Name = "MenuItemEveryYearCase";
            this.MenuItemEveryYearCase.Size = new System.Drawing.Size(172, 22);
            this.MenuItemEveryYearCase.Text = "年度收支情况";
            this.MenuItemEveryYearCase.Click += new System.EventHandler(this.MenuItemEveryYearCase_Click);
            // 
            // MenuItemTypeCase
            // 
            this.MenuItemTypeCase.Name = "MenuItemTypeCase";
            this.MenuItemTypeCase.Size = new System.Drawing.Size(172, 22);
            this.MenuItemTypeCase.Text = "收支类别统计情况";
            this.MenuItemTypeCase.Click += new System.EventHandler(this.MenuItemTypeCase_Click);
            // 
            // MenuItemAccountManage
            // 
            this.MenuItemAccountManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddUser,
            this.MenuItemDeleteUser,
            this.MenuItemChangeUserInformation});
            this.MenuItemAccountManage.Name = "MenuItemAccountManage";
            this.MenuItemAccountManage.Size = new System.Drawing.Size(68, 21);
            this.MenuItemAccountManage.Text = "账户管理";
            // 
            // MenuItemAddUser
            // 
            this.MenuItemAddUser.Name = "MenuItemAddUser";
            this.MenuItemAddUser.Size = new System.Drawing.Size(148, 22);
            this.MenuItemAddUser.Text = "添加账户";
            this.MenuItemAddUser.Click += new System.EventHandler(this.MenuItemAddUser_Click);
            // 
            // MenuItemDeleteUser
            // 
            this.MenuItemDeleteUser.Name = "MenuItemDeleteUser";
            this.MenuItemDeleteUser.Size = new System.Drawing.Size(148, 22);
            this.MenuItemDeleteUser.Text = "删除账户";
            this.MenuItemDeleteUser.Click += new System.EventHandler(this.MenuItemDeleteUser_Click);
            // 
            // MenuItemChangeUserInformation
            // 
            this.MenuItemChangeUserInformation.Name = "MenuItemChangeUserInformation";
            this.MenuItemChangeUserInformation.Size = new System.Drawing.Size(148, 22);
            this.MenuItemChangeUserInformation.Text = "修改账户信息";
            this.MenuItemChangeUserInformation.Click += new System.EventHandler(this.MenuItemChangeUserInformation_Click);
            // 
            // MenuItemOtherFunction
            // 
            this.MenuItemOtherFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCalc,
            this.MenuItemCalendar,
            this.MenuItemExchangeRate,
            this.MenuItemMail});
            this.MenuItemOtherFunction.Name = "MenuItemOtherFunction";
            this.MenuItemOtherFunction.Size = new System.Drawing.Size(68, 21);
            this.MenuItemOtherFunction.Text = "辅助功能";
            // 
            // MenuItemCalc
            // 
            this.MenuItemCalc.Name = "MenuItemCalc";
            this.MenuItemCalc.Size = new System.Drawing.Size(124, 22);
            this.MenuItemCalc.Text = "计算器";
            this.MenuItemCalc.Click += new System.EventHandler(this.MenuItemCalc_Click);
            // 
            // MenuItemCalendar
            // 
            this.MenuItemCalendar.Name = "MenuItemCalendar";
            this.MenuItemCalendar.Size = new System.Drawing.Size(124, 22);
            this.MenuItemCalendar.Text = "日历";
            this.MenuItemCalendar.Click += new System.EventHandler(this.MenuItemCalendar_Click);
            // 
            // MenuItemExchangeRate
            // 
            this.MenuItemExchangeRate.Name = "MenuItemExchangeRate";
            this.MenuItemExchangeRate.Size = new System.Drawing.Size(124, 22);
            this.MenuItemExchangeRate.Text = "汇率转换";
            this.MenuItemExchangeRate.Click += new System.EventHandler(this.MenuItemExchangeRate_Click);
            // 
            // MenuItemMail
            // 
            this.MenuItemMail.Name = "MenuItemMail";
            this.MenuItemMail.Size = new System.Drawing.Size(124, 22);
            this.MenuItemMail.Text = "邮件发送";
            this.MenuItemMail.Click += new System.EventHandler(this.MenuItemMail_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAboutProgram,
            this.MenuItemSettings});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 21);
            this.MenuItemHelp.Text = "帮助";
            // 
            // MenuItemAboutProgram
            // 
            this.MenuItemAboutProgram.Name = "MenuItemAboutProgram";
            this.MenuItemAboutProgram.Size = new System.Drawing.Size(124, 22);
            this.MenuItemAboutProgram.Text = "关于程序";
            this.MenuItemAboutProgram.Click += new System.EventHandler(this.MenuItemAboutProgram_Click);
            // 
            // MenuItemSettings
            // 
            this.MenuItemSettings.Name = "MenuItemSettings";
            this.MenuItemSettings.Size = new System.Drawing.Size(124, 22);
            this.MenuItemSettings.Text = "程序设置";
            this.MenuItemSettings.Click += new System.EventHandler(this.MenuItemSettings_Click);
            // 
            // toolStripOption
            // 
            this.toolStripOption.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripOption.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripButtonSwitchUser,
            this.StripButtonAddRecord,
            this.StripButtonCalc,
            this.StripButtonCalendar,
            this.StripButtonAbout,
            this.StripButtonSet,
            this.toolStripSeparator1,
            this.toolStripExit});
            this.toolStripOption.Location = new System.Drawing.Point(0, 25);
            this.toolStripOption.Name = "toolStripOption";
            this.toolStripOption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripOption.Size = new System.Drawing.Size(1159, 72);
            this.toolStripOption.Stretch = true;
            this.toolStripOption.TabIndex = 2;
            this.toolStripOption.Text = "toolStrip1";
            // 
            // StripButtonSwitchUser
            // 
            this.StripButtonSwitchUser.Image = global::AccountingSystem.Properties.Resources.switchuser;
            this.StripButtonSwitchUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StripButtonSwitchUser.Name = "StripButtonSwitchUser";
            this.StripButtonSwitchUser.Size = new System.Drawing.Size(60, 69);
            this.StripButtonSwitchUser.Text = "切换用户";
            this.StripButtonSwitchUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StripButtonSwitchUser.Click += new System.EventHandler(this.StripButtonSwitchUser_Click);
            // 
            // StripButtonAddRecord
            // 
            this.StripButtonAddRecord.Image = ((System.Drawing.Image)(resources.GetObject("StripButtonAddRecord.Image")));
            this.StripButtonAddRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StripButtonAddRecord.Name = "StripButtonAddRecord";
            this.StripButtonAddRecord.Size = new System.Drawing.Size(52, 69);
            this.StripButtonAddRecord.Text = "记账";
            this.StripButtonAddRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StripButtonAddRecord.Click += new System.EventHandler(this.StripButtonAddRecord_Click);
            // 
            // StripButtonCalc
            // 
            this.StripButtonCalc.AutoSize = false;
            this.StripButtonCalc.Image = ((System.Drawing.Image)(resources.GetObject("StripButtonCalc.Image")));
            this.StripButtonCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StripButtonCalc.Name = "StripButtonCalc";
            this.StripButtonCalc.Size = new System.Drawing.Size(60, 69);
            this.StripButtonCalc.Text = "计算器";
            this.StripButtonCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StripButtonCalc.Click += new System.EventHandler(this.StripButtonCalc_Click);
            // 
            // StripButtonCalendar
            // 
            this.StripButtonCalendar.AutoSize = false;
            this.StripButtonCalendar.Image = ((System.Drawing.Image)(resources.GetObject("StripButtonCalendar.Image")));
            this.StripButtonCalendar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StripButtonCalendar.Name = "StripButtonCalendar";
            this.StripButtonCalendar.Size = new System.Drawing.Size(60, 69);
            this.StripButtonCalendar.Text = "日历";
            this.StripButtonCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StripButtonCalendar.Click += new System.EventHandler(this.StripButtonCalendar_Click);
            // 
            // StripButtonAbout
            // 
            this.StripButtonAbout.AutoSize = false;
            this.StripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("StripButtonAbout.Image")));
            this.StripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StripButtonAbout.Name = "StripButtonAbout";
            this.StripButtonAbout.Size = new System.Drawing.Size(60, 69);
            this.StripButtonAbout.Text = "关于";
            this.StripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StripButtonAbout.Click += new System.EventHandler(this.StripButtonAbout_Click);
            // 
            // StripButtonSet
            // 
            this.StripButtonSet.AutoSize = false;
            this.StripButtonSet.Image = ((System.Drawing.Image)(resources.GetObject("StripButtonSet.Image")));
            this.StripButtonSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StripButtonSet.Name = "StripButtonSet";
            this.StripButtonSet.Size = new System.Drawing.Size(60, 69);
            this.StripButtonSet.Text = "设置";
            this.StripButtonSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StripButtonSet.Click += new System.EventHandler(this.StripButtonSet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(52, 69);
            this.toolStripExit.Text = "退出";
            this.toolStripExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusCurrentUser});
            this.statusStripMain.Location = new System.Drawing.Point(0, 465);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1159, 22);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel.Text = "欢迎使用家庭记账软件";
            // 
            // toolStripStatusCurrentUser
            // 
            this.toolStripStatusCurrentUser.Name = "toolStripStatusCurrentUser";
            this.toolStripStatusCurrentUser.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AccountingSystem.Properties.Resources.MainBackImage;
            this.ClientSize = new System.Drawing.Size(1159, 487);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripOption);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家庭记账软件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripOption.ResumeLayout(false);
            this.toolStripOption.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOption;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangeUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFinance;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReport;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountManage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOtherFunction;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCalc;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCalendar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExchangeRate;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMail;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAboutProgram;
        public System.Windows.Forms.ToolStrip toolStripOption;
        private System.Windows.Forms.ToolStripButton StripButtonSwitchUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangeRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTypeAdmin;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEveryDayCase;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEveryMonthCase;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEveryYearCase;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.ToolStripButton StripButtonCalc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton StripButtonCalendar;
        private System.Windows.Forms.ToolStripButton StripButtonAbout;
        public System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripButton StripButtonSet;
        public System.Windows.Forms.ToolStripMenuItem MenuItemAddUser;
        public System.Windows.Forms.ToolStripMenuItem MenuItemDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangeUserInformation;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTypeCase;
        private System.Windows.Forms.ToolStripButton StripButtonAddRecord;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusCurrentUser;
    }
}