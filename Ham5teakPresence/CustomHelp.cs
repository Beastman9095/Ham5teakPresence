using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

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
