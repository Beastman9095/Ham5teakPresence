namespace Ham5teakPresence
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.custom = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayOnCloseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoStartOnStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(45, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update Presence";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(264, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Presence";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(171, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // custom
            // 
            this.custom.Location = new System.Drawing.Point(205, 41);
            this.custom.MaximumSize = new System.Drawing.Size(169, 23);
            this.custom.MinimumSize = new System.Drawing.Size(169, 23);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(169, 23);
            this.custom.TabIndex = 3;
            this.custom.Text = "Create Your Custom Presence";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.Click += new System.EventHandler(this.custom_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(48, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About Rich Presence";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(205, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Create Your Custom Presence";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(48, 66);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(108, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About Rich Presence";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem1,
            this.minimizeToTrayOnCloseToolStripMenuItem1,
            this.autoStartOnStartupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem1
            // 
            this.themeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.lightModeToolStripMenuItem});
            this.themeToolStripMenuItem1.Name = "themeToolStripMenuItem1";
            this.themeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.themeToolStripMenuItem1.ShowShortcutKeys = false;
            this.themeToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.themeToolStripMenuItem1.Text = "Theme";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Checked = true;
            this.darkModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.lightModeToolStripMenuItem.Text = "Light Mode";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // minimizeToTrayOnCloseToolStripMenuItem1
            // 
            this.minimizeToTrayOnCloseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem,
            this.noToolStripMenuItem});
            this.minimizeToTrayOnCloseToolStripMenuItem1.Name = "minimizeToTrayOnCloseToolStripMenuItem1";
            this.minimizeToTrayOnCloseToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.minimizeToTrayOnCloseToolStripMenuItem1.ShowShortcutKeys = false;
            this.minimizeToTrayOnCloseToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.minimizeToTrayOnCloseToolStripMenuItem1.Text = "Minimize To Tray On Close";
            // 
            // yesToolStripMenuItem
            // 
            this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            this.yesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.yesToolStripMenuItem.ShowShortcutKeys = false;
            this.yesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yesToolStripMenuItem.Text = "Yes";
            this.yesToolStripMenuItem.Click += new System.EventHandler(this.yesToolStripMenuItem_Click);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Checked = true;
            this.noToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.noToolStripMenuItem.ShowShortcutKeys = false;
            this.noToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGuideToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewGuideToolStripMenuItem
            // 
            this.viewGuideToolStripMenuItem.Name = "viewGuideToolStripMenuItem";
            this.viewGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.viewGuideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewGuideToolStripMenuItem.Text = "View Guide";
            this.viewGuideToolStripMenuItem.Click += new System.EventHandler(this.viewGuideToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Ham5teak Presence";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // autoStartOnStartupToolStripMenuItem
            // 
            this.autoStartOnStartupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem1,
            this.noToolStripMenuItem1});
            this.autoStartOnStartupToolStripMenuItem.Name = "autoStartOnStartupToolStripMenuItem";
            this.autoStartOnStartupToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.autoStartOnStartupToolStripMenuItem.Text = "Auto-Start On Startup";
            // 
            // yesToolStripMenuItem1
            // 
            this.yesToolStripMenuItem1.Name = "yesToolStripMenuItem1";
            this.yesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.yesToolStripMenuItem1.Text = "Enabled";
            this.yesToolStripMenuItem1.Click += new System.EventHandler(this.yesToolStripMenuItem1_Click);
            // 
            // noToolStripMenuItem1
            // 
            this.noToolStripMenuItem1.Name = "noToolStripMenuItem1";
            this.noToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.noToolStripMenuItem1.Text = "Disabled";
            this.noToolStripMenuItem1.Click += new System.EventHandler(this.noToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 96);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 135);
            this.MinimumSize = new System.Drawing.Size(442, 135);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ham5teak Presence";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button custom;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayOnCloseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGuideToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoStartOnStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem1;
    }
}

