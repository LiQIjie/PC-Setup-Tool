
namespace PCSetupTool
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtLabview = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtStartup = new System.Windows.Forms.Button();
            this.CheckGroup = new System.Windows.Forms.GroupBox();
            this.BtAccount = new System.Windows.Forms.Button();
            this.BtControl = new System.Windows.Forms.Button();
            this.BtDevice = new System.Windows.Forms.Button();
            this.BtWinOpFeature = new System.Windows.Forms.Button();
            this.BtBoot = new System.Windows.Forms.Button();
            this.BtSystem = new System.Windows.Forms.Button();
            this.BtTaskBarIcon = new System.Windows.Forms.Button();
            this.BtShowComputer = new System.Windows.Forms.Button();
            this.BtIcon = new System.Windows.Forms.Button();
            this.BtFileExt = new System.Windows.Forms.Button();
            this.BtPowerPlan = new System.Windows.Forms.Button();
            this.BtName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtSystemInfo = new System.Windows.Forms.RichTextBox();
            this.BtRefresh = new System.Windows.Forms.Button();
            this.ファイル設定FileConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConfiguration = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CheckGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MenuConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.CheckGroup);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LTSW";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtLabview);
            this.groupBox2.Controls.Add(this.BtStartup);
            this.groupBox2.Location = new System.Drawing.Point(451, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utility Group";
            // 
            // BtLabview
            // 
            this.BtLabview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtLabview.ImageIndex = 3;
            this.BtLabview.ImageList = this.imageList1;
            this.BtLabview.Location = new System.Drawing.Point(19, 20);
            this.BtLabview.Name = "BtLabview";
            this.BtLabview.Size = new System.Drawing.Size(135, 33);
            this.BtLabview.TabIndex = 2;
            this.BtLabview.Text = "Labview設定\r\n(Labview Setting)";
            this.BtLabview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtLabview.UseVisualStyleBackColor = true;
            this.BtLabview.Click += new System.EventHandler(this.BtLabview_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Desktop.png");
            this.imageList1.Images.SetKeyName(1, "DEVICES.png");
            this.imageList1.Images.SetKeyName(2, "File Types.png");
            this.imageList1.Images.SetKeyName(3, "LabView.png");
            this.imageList1.Images.SetKeyName(4, "Power.png");
            this.imageList1.Images.SetKeyName(5, "startup.png");
            this.imageList1.Images.SetKeyName(6, "User Groups.png");
            this.imageList1.Images.SetKeyName(7, "功能 (1).png");
            this.imageList1.Images.SetKeyName(8, "功能管理.png");
            this.imageList1.Images.SetKeyName(9, "control.png");
            this.imageList1.Images.SetKeyName(10, "desktop.png");
            this.imageList1.Images.SetKeyName(11, "CLOUD CONTROL PANEL.png");
            this.imageList1.Images.SetKeyName(12, "system (2).png");
            this.imageList1.Images.SetKeyName(13, "springboot.png");
            this.imageList1.Images.SetKeyName(14, "Terminal.png");
            this.imageList1.Images.SetKeyName(15, "taskbar.png");
            this.imageList1.Images.SetKeyName(16, "system.png");
            this.imageList1.Images.SetKeyName(17, "rocket.ico");
            // 
            // BtStartup
            // 
            this.BtStartup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtStartup.ImageIndex = 5;
            this.BtStartup.ImageList = this.imageList1;
            this.BtStartup.Location = new System.Drawing.Point(166, 20);
            this.BtStartup.Name = "BtStartup";
            this.BtStartup.Size = new System.Drawing.Size(135, 33);
            this.BtStartup.TabIndex = 2;
            this.BtStartup.Text = "スタートアップ\r\n(Startup)";
            this.BtStartup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtStartup.UseVisualStyleBackColor = true;
            this.BtStartup.Click += new System.EventHandler(this.BtStartup_Click);
            // 
            // CheckGroup
            // 
            this.CheckGroup.Controls.Add(this.BtAccount);
            this.CheckGroup.Controls.Add(this.BtControl);
            this.CheckGroup.Controls.Add(this.BtDevice);
            this.CheckGroup.Controls.Add(this.BtWinOpFeature);
            this.CheckGroup.Controls.Add(this.BtBoot);
            this.CheckGroup.Controls.Add(this.BtSystem);
            this.CheckGroup.Controls.Add(this.BtTaskBarIcon);
            this.CheckGroup.Controls.Add(this.BtShowComputer);
            this.CheckGroup.Controls.Add(this.BtIcon);
            this.CheckGroup.Controls.Add(this.BtFileExt);
            this.CheckGroup.Controls.Add(this.BtPowerPlan);
            this.CheckGroup.Controls.Add(this.BtName);
            this.CheckGroup.Location = new System.Drawing.Point(451, 6);
            this.CheckGroup.Name = "CheckGroup";
            this.CheckGroup.Size = new System.Drawing.Size(317, 333);
            this.CheckGroup.TabIndex = 0;
            this.CheckGroup.TabStop = false;
            this.CheckGroup.Text = "Shortcut Group";
            // 
            // BtAccount
            // 
            this.BtAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAccount.ImageIndex = 6;
            this.BtAccount.ImageList = this.imageList1;
            this.BtAccount.Location = new System.Drawing.Point(19, 72);
            this.BtAccount.Name = "BtAccount";
            this.BtAccount.Size = new System.Drawing.Size(135, 33);
            this.BtAccount.TabIndex = 3;
            this.BtAccount.Text = "ユーザー\r\n(Account)";
            this.BtAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAccount.UseVisualStyleBackColor = true;
            this.BtAccount.Click += new System.EventHandler(this.BtAccount_Click);
            // 
            // BtControl
            // 
            this.BtControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtControl.ImageIndex = 10;
            this.BtControl.ImageList = this.imageList1;
            this.BtControl.Location = new System.Drawing.Point(166, 126);
            this.BtControl.Name = "BtControl";
            this.BtControl.Size = new System.Drawing.Size(135, 33);
            this.BtControl.TabIndex = 2;
            this.BtControl.Text = "コントロールパネル\r\n(ControlPannel)";
            this.BtControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtControl.UseVisualStyleBackColor = true;
            this.BtControl.Click += new System.EventHandler(this.BtControl_Click);
            // 
            // BtDevice
            // 
            this.BtDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDevice.ImageIndex = 16;
            this.BtDevice.ImageList = this.imageList1;
            this.BtDevice.Location = new System.Drawing.Point(166, 233);
            this.BtDevice.Name = "BtDevice";
            this.BtDevice.Size = new System.Drawing.Size(135, 33);
            this.BtDevice.TabIndex = 2;
            this.BtDevice.Text = "デバイス\r\n(Devices)";
            this.BtDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtDevice.UseVisualStyleBackColor = true;
            this.BtDevice.Click += new System.EventHandler(this.BtDevice_Click);
            // 
            // BtWinOpFeature
            // 
            this.BtWinOpFeature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtWinOpFeature.ImageIndex = 7;
            this.BtWinOpFeature.ImageList = this.imageList1;
            this.BtWinOpFeature.Location = new System.Drawing.Point(166, 286);
            this.BtWinOpFeature.Name = "BtWinOpFeature";
            this.BtWinOpFeature.Size = new System.Drawing.Size(135, 33);
            this.BtWinOpFeature.TabIndex = 2;
            this.BtWinOpFeature.Text = "Win機能\r\n(OptionFeature)";
            this.BtWinOpFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtWinOpFeature.UseVisualStyleBackColor = true;
            this.BtWinOpFeature.Click += new System.EventHandler(this.BtWinOpFeature_Click);
            // 
            // BtBoot
            // 
            this.BtBoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBoot.ImageIndex = 13;
            this.BtBoot.ImageList = this.imageList1;
            this.BtBoot.Location = new System.Drawing.Point(166, 72);
            this.BtBoot.Name = "BtBoot";
            this.BtBoot.Size = new System.Drawing.Size(135, 33);
            this.BtBoot.TabIndex = 2;
            this.BtBoot.Text = "ブートマネージャー\r\n(Boot)";
            this.BtBoot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBoot.UseVisualStyleBackColor = true;
            this.BtBoot.Click += new System.EventHandler(this.BtBoot_Click);
            // 
            // BtSystem
            // 
            this.BtSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSystem.ImageIndex = 12;
            this.BtSystem.ImageList = this.imageList1;
            this.BtSystem.Location = new System.Drawing.Point(166, 18);
            this.BtSystem.Name = "BtSystem";
            this.BtSystem.Size = new System.Drawing.Size(135, 33);
            this.BtSystem.TabIndex = 2;
            this.BtSystem.Text = "システム\r\n(System)";
            this.BtSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSystem.UseVisualStyleBackColor = true;
            this.BtSystem.Click += new System.EventHandler(this.BtSystem_Click);
            // 
            // BtTaskBarIcon
            // 
            this.BtTaskBarIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtTaskBarIcon.ImageIndex = 15;
            this.BtTaskBarIcon.ImageList = this.imageList1;
            this.BtTaskBarIcon.Location = new System.Drawing.Point(166, 179);
            this.BtTaskBarIcon.Name = "BtTaskBarIcon";
            this.BtTaskBarIcon.Size = new System.Drawing.Size(135, 33);
            this.BtTaskBarIcon.TabIndex = 2;
            this.BtTaskBarIcon.Text = "タスクバー　アイコン\r\n(TaskBarIcon)";
            this.BtTaskBarIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtTaskBarIcon.UseVisualStyleBackColor = true;
            this.BtTaskBarIcon.Click += new System.EventHandler(this.BtTaskBarIcon_Click);
            // 
            // BtShowComputer
            // 
            this.BtShowComputer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtShowComputer.ImageIndex = 9;
            this.BtShowComputer.ImageList = this.imageList1;
            this.BtShowComputer.Location = new System.Drawing.Point(19, 179);
            this.BtShowComputer.Name = "BtShowComputer";
            this.BtShowComputer.Size = new System.Drawing.Size(135, 33);
            this.BtShowComputer.TabIndex = 2;
            this.BtShowComputer.Text = "PCアイコン表示\r\n(Show PC Icon)";
            this.BtShowComputer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtShowComputer.UseVisualStyleBackColor = true;
            this.BtShowComputer.Click += new System.EventHandler(this.BtShowComputer_Click);
            // 
            // BtIcon
            // 
            this.BtIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtIcon.ImageIndex = 1;
            this.BtIcon.ImageList = this.imageList1;
            this.BtIcon.Location = new System.Drawing.Point(19, 233);
            this.BtIcon.Name = "BtIcon";
            this.BtIcon.Size = new System.Drawing.Size(135, 33);
            this.BtIcon.TabIndex = 2;
            this.BtIcon.Text = "アイコン　サイズ\r\n(Icon Size)";
            this.BtIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtIcon.UseVisualStyleBackColor = true;
            this.BtIcon.Click += new System.EventHandler(this.BtIcon_Click);
            // 
            // BtFileExt
            // 
            this.BtFileExt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtFileExt.ImageIndex = 2;
            this.BtFileExt.ImageList = this.imageList1;
            this.BtFileExt.Location = new System.Drawing.Point(19, 286);
            this.BtFileExt.Name = "BtFileExt";
            this.BtFileExt.Size = new System.Drawing.Size(135, 33);
            this.BtFileExt.TabIndex = 2;
            this.BtFileExt.Text = "拡張子\r\n(Extension)";
            this.BtFileExt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtFileExt.UseVisualStyleBackColor = true;
            this.BtFileExt.Click += new System.EventHandler(this.BtFileExt_Click);
            // 
            // BtPowerPlan
            // 
            this.BtPowerPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtPowerPlan.ImageIndex = 4;
            this.BtPowerPlan.ImageList = this.imageList1;
            this.BtPowerPlan.Location = new System.Drawing.Point(19, 126);
            this.BtPowerPlan.Name = "BtPowerPlan";
            this.BtPowerPlan.Size = new System.Drawing.Size(135, 33);
            this.BtPowerPlan.TabIndex = 2;
            this.BtPowerPlan.Text = "電源設定\r\n(PowerPlan)";
            this.BtPowerPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtPowerPlan.UseVisualStyleBackColor = true;
            this.BtPowerPlan.Click += new System.EventHandler(this.BtPowerPlan_Click);
            // 
            // BtName
            // 
            this.BtName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtName.ImageIndex = 0;
            this.BtName.ImageList = this.imageList1;
            this.BtName.Location = new System.Drawing.Point(19, 18);
            this.BtName.Name = "BtName";
            this.BtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtName.Size = new System.Drawing.Size(135, 33);
            this.BtName.TabIndex = 1;
            this.BtName.Text = "コンピュータ名\r\n(PC Name)";
            this.BtName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtName.UseVisualStyleBackColor = true;
            this.BtName.Click += new System.EventHandler(this.BtName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtSystemInfo);
            this.groupBox1.Controls.Add(this.BtRefresh);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // rtSystemInfo
            // 
            this.rtSystemInfo.AutoSize = true;
            this.rtSystemInfo.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtSystemInfo.Location = new System.Drawing.Point(5, 30);
            this.rtSystemInfo.Name = "rtSystemInfo";
            this.rtSystemInfo.ReadOnly = true;
            this.rtSystemInfo.Size = new System.Drawing.Size(430, 375);
            this.rtSystemInfo.TabIndex = 2;
            this.rtSystemInfo.Text = "";
            // 
            // BtRefresh
            // 
            this.BtRefresh.Location = new System.Drawing.Point(379, 9);
            this.BtRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Size = new System.Drawing.Size(56, 18);
            this.BtRefresh.TabIndex = 1;
            this.BtRefresh.Text = "Refresh";
            this.BtRefresh.UseVisualStyleBackColor = true;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // ファイル設定FileConfigurationToolStripMenuItem
            // 
            this.ファイル設定FileConfigurationToolStripMenuItem.Name = "ファイル設定FileConfigurationToolStripMenuItem";
            this.ファイル設定FileConfigurationToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.ファイル設定FileConfigurationToolStripMenuItem.Text = "管理ツール(AdminTools)";
            this.ファイル設定FileConfigurationToolStripMenuItem.Click += new System.EventHandler(this.ファイル設定FileConfigurationToolStripMenuItem_Click);
            // 
            // MenuConfiguration
            // 
            this.MenuConfiguration.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuConfiguration.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイル設定FileConfigurationToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MenuConfiguration.Location = new System.Drawing.Point(0, 0);
            this.MenuConfiguration.Name = "MenuConfiguration";
            this.MenuConfiguration.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuConfiguration.ShowItemToolTips = true;
            this.MenuConfiguration.Size = new System.Drawing.Size(785, 24);
            this.MenuConfiguration.TabIndex = 1;
            this.MenuConfiguration.Text = "ファイル設定(File Configuration)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.MouseLeave += new System.EventHandler(this.helpToolStripMenuItem_MouseLeave);
            this.helpToolStripMenuItem.MouseHover += new System.EventHandler(this.helpToolStripMenuItem_MouseHover);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Advice";
            this.toolStripMenuItem1.ToolTipText = "Click to send mail";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(785, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuConfiguration);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCセットアップツール(PC Setup Tool)　Admin権限対応";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.CheckGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MenuConfiguration.ResumeLayout(false);
            this.MenuConfiguration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox CheckGroup;
        private System.Windows.Forms.Button BtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtAccount;
        private System.Windows.Forms.Button BtShowComputer;
        private System.Windows.Forms.Button BtIcon;
        private System.Windows.Forms.Button BtFileExt;
        private System.Windows.Forms.Button BtPowerPlan;
        private System.Windows.Forms.Button BtControl;
        private System.Windows.Forms.Button BtTaskBarIcon;
        private System.Windows.Forms.Button BtSystem;
        private System.Windows.Forms.Button BtDevice;
        private System.Windows.Forms.ToolStripMenuItem ファイル設定FileConfigurationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuConfiguration;
        private System.Windows.Forms.Button BtStartup;
        private System.Windows.Forms.Button BtLabview;
        private System.Windows.Forms.Button BtRefresh;
        private System.Windows.Forms.RichTextBox rtSystemInfo;
        private System.Windows.Forms.Button BtBoot;
        private System.Windows.Forms.Button BtWinOpFeature;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

