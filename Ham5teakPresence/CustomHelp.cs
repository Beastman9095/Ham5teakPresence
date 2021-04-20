using DiscordRPC;
using System;
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

        public DiscordRpcClient Client { get; private set; }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
