using DiscordRPC;
using System;
using System.Windows.Forms;

namespace Ham5teakPresence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool inita = false;
        bool enabled = false;

        public DiscordRpcClient Client { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enabled != false)
            {
                string message1 = "Presence is already applied.";
                string title1 = "Ham5teak Presence";
                MessageBox.Show(message1, title1);
            }
            else
            {
                enabled = true;
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
                enabled = false;
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
    }
}
