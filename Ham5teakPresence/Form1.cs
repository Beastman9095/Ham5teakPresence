using DiscordRPC;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ham5teakPresence
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIsClosing);
            notifyIcon1.Click += new System.EventHandler(notifyIcon1_Click);
        }
        private void notifyIcon1_Click(object sender, System.EventArgs e)
        {
            this.Activate();
            this.Show();
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (yesToolStripMenuItem.Checked == true && e.CloseReason == CloseReason.UserClosing)
            {

                e.Cancel = true;
                this.Hide();


            }
        }

        public class RendererEx : ToolStripProfessionalRenderer
        {

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                e.Item.BackColor = Color.FromArgb(45, 45, 48);
            }

        }
        bool inita = false;

        public DiscordRpcClient Client { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

            yesToolStripMenuItem.Checked = Properties.Settings.Default.yes;
            noToolStripMenuItem.Checked = Properties.Settings.Default.no;
            darkModeToolStripMenuItem.Checked = Properties.Settings.Default.dark;
            lightModeToolStripMenuItem.Checked = Properties.Settings.Default.light;

        }

        protected override void OnShown(EventArgs e)
        {

            if (Properties.Settings.Default.dark == true)
            {

                button1.TabStop = true;
                button1.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderSize = 0;
                button2.TabStop = true;
                button2.FlatStyle = FlatStyle.Flat;
                button2.FlatAppearance.BorderSize = 0;
                button4.TabStop = true;
                button4.FlatStyle = FlatStyle.Flat;
                button4.FlatAppearance.BorderSize = 0;
                button3.TabStop = true;
                button3.FlatStyle = FlatStyle.Flat;
                button3.FlatAppearance.BorderSize = 0;
                ApplyTheme(Color.FromArgb(34, 34, 34), Color.FromArgb(56, 56, 56), Color.FromArgb(242, 240, 219), Color.FromArgb(56, 56, 56));

            }
            else
            {

                ApplyTheme(Color.FromArgb(244, 244, 244), Color.FromArgb(225, 225, 225), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255));

            }

        }

        void ApplyTheme(Color back, Color btn, Color TextColor, Color menu)
        {
            this.BackColor = back;
            button1.BackColor = btn;
            button1.ForeColor = TextColor;
            button1.FlatAppearance.BorderColor = btn;
            button2.BackColor = btn;
            button2.ForeColor = TextColor;
            button2.FlatAppearance.BorderColor = btn;
            button3.BackColor = btn;
            button3.ForeColor = TextColor;
            button3.FlatAppearance.BorderColor = btn;
            button4.BackColor = btn;
            button4.ForeColor = TextColor;
            button4.FlatAppearance.BorderColor = btn;
            menuStrip1.Renderer = new RendererEx();
            this.menuStrip1.BackColor = menu;
            this.menuStrip1.ForeColor = TextColor;
            this.settingsToolStripMenuItem.ForeColor = TextColor;
            this.settingsToolStripMenuItem.BackColor = menu;
            this.helpToolStripMenuItem.ForeColor = TextColor;
            this.helpToolStripMenuItem.BackColor = menu;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customform = Application.OpenForms["Custom"];
            if (inita != false)
            {
                string message1 = "Presence is already applied.";
                string title1 = "Ham5teak Presence";
                MessageBox.Show(message1, title1);
            }
            else if (customform != null)
            {
                string message = "Please close the Custom Presence application first.";
                string title = "Ham5teak Presence";
                MessageBox.Show(message, title);
                return;
            }
            else
            {
                inita = true;
                Client = new DiscordRpcClient("833302091790417920");
                Client.Initialize();
                Client.SetPresence(new RichPresence()
                {
                    Details = "",
                    State = "SG Cracked Minecraft Server",
                    Assets = new Assets()
                    {
                        LargeImageKey = "icon",
                        LargeImageText = "Ham5teak",
                        SmallImageKey = ""
                    },
                    Buttons = new DiscordRPC.Button[]
                    {
                    new DiscordRPC.Button() { Label = "Join Discord", Url = "https://discord.gg/QNfQmHg" },
                    new DiscordRPC.Button() { Label = "Visit Shop", Url = "http://shop.ham5teak.xyz/" }
                    }
                });
                string message = "Presence has been applied.";
                string title = "Ham5teak Presence";
                MessageBox.Show(message, title);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (inita == true)
            {
                Client.Dispose();
                inita = false;
                string message2 = "Presence has been removed.";
                string title2 = "Ham5teak Presence";
                MessageBox.Show(message2, title2);
            }
            else
            {
                string message = "Please apply the presence first.";
                string title = "Ham5teak Presence";
                MessageBox.Show(message, title);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["CMessageB"];
            if (form != null)
            {
                form = new CMessageB();
                return;
            }
            CMessageB helpBox = new CMessageB();
            helpBox.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/developers/docs/rich-presence/how-to");
        }

        private void custom_Click(object sender, EventArgs e)
        {

            var form = Application.OpenForms["Custom"];
            if (form != null)
            {
                form = new Custom();
                return;
            }
            Custom helpBox = new Custom();
            helpBox.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/developers/docs/rich-presence/how-to");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inita == true)
            {

                string message = "Please remove your current presence first.";
                string title = "Custom Presence";
                MessageBox.Show(message, title);
                return;

            }
            var form = Application.OpenForms["Custom"];
            if (form != null)
            {
                form = new Custom();
                return;
            }
            Custom helpBox = new Custom();
            helpBox.Show();

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.TabStop = true;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.TabStop = true;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button4.TabStop = true;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button3.TabStop = true;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            lightModeToolStripMenuItem.Checked = false;
            darkModeToolStripMenuItem.Checked = true;
            Properties.Settings.Default.dark = true;
            Properties.Settings.Default.light = false;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            ApplyTheme(Color.FromArgb(34, 34, 34), Color.FromArgb(56, 56, 56), Color.FromArgb(242, 240, 219), Color.FromArgb(56, 56, 56));
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.TabStop = true;
            button1.FlatStyle = FlatStyle.Standard;
            button1.FlatAppearance.BorderSize = 0;
            button2.TabStop = true;
            button2.FlatStyle = FlatStyle.Standard;
            button2.FlatAppearance.BorderSize = 0;
            button4.TabStop = true;
            button4.FlatStyle = FlatStyle.Standard;
            button4.FlatAppearance.BorderSize = 0;
            button3.TabStop = true;
            button3.FlatStyle = FlatStyle.Standard;
            button3.FlatAppearance.BorderSize = 1;
            darkModeToolStripMenuItem.Checked = false;
            lightModeToolStripMenuItem.Checked = true;
            Properties.Settings.Default.dark = false;
            Properties.Settings.Default.light = true;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            ApplyTheme(Color.FromArgb(244, 244, 244), Color.FromArgb(225, 225, 225), Color.FromArgb(0, 0, 0), Color.FromArgb(255, 255, 255));
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yesToolStripMenuItem.Checked = true;
            noToolStripMenuItem.Checked = false;
            Properties.Settings.Default.yes = true;
            Properties.Settings.Default.no = false;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noToolStripMenuItem.Checked = true;
            yesToolStripMenuItem.Checked = false;
            Properties.Settings.Default.yes = false;
            Properties.Settings.Default.no = true;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Activate();
            this.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (yesToolStripMenuItem.Checked == true)
            {
                noToolStripMenuItem.Checked = true;
                yesToolStripMenuItem.Checked = false;
                this.Close();
            }
            else this.Close();
        }

        private void contextMenuStrip1_Opening_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            yesToolStripMenuItem.Checked = Properties.Settings.Default.yes;
            noToolStripMenuItem.Checked = Properties.Settings.Default.no;
            darkModeToolStripMenuItem.Checked = Properties.Settings.Default.dark;
            lightModeToolStripMenuItem.Checked = Properties.Settings.Default.light;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Beastman9095/Ham5teakPresence/wiki/Guide-To-Discord-Rich-Presences#steps");
        }
    }
}
