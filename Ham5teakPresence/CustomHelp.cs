using DiscordRPC;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ham5teakPresence
{
    public partial class CustomHelp : Form
    {
        public CustomHelp()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/developers/applications");
        }


        protected override void OnShown(EventArgs e)
        {

            if (Properties.Settings.Default.dark == true)
            {
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
            label1.ForeColor = TextColor;
            label2.ForeColor = TextColor;
            label3.ForeColor = TextColor;
            label4.ForeColor = TextColor;
            label5.ForeColor = TextColor;
            label6.ForeColor = TextColor;
            label7.ForeColor = TextColor;
            label8.ForeColor = TextColor;
            label9.ForeColor = TextColor;
            label10.ForeColor = TextColor;
            label11.ForeColor = TextColor;
            label12.ForeColor = TextColor;

        }

        public DiscordRpcClient Client { get; private set; }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
