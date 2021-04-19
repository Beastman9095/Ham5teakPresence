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
    public partial class Custom : Form
    {
        public Custom()
        {
            InitializeComponent();
        }

        bool inita = false;
        bool enabled = false;

        public DiscordRpcClient Client { get; private set; }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["CustomHelp"];
            if (form != null)
            {
                form = new CustomHelp();
                return;
            }
            CustomHelp chelpBox = new CustomHelp();
            chelpBox.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string appid;
            appid = textBox1.Text;
            string details;
            details = detailsbox.Text;
            string status;
            status = statusbox.Text;
            string lik;
            lik = largeimagekeybox.Text;
            string lit;
            lit = largeimagetextbox.Text;
            string sik;
            sik = smallimagekeybox.Text;
            string sit;
            sit = smallimagetextbox.Text;
            string b1t;
            b1t = button1text.Text;
            string b1u;
            b1u = button1url.Text;
            string b2t;
            b2t = button2text.Text;
            string b2u;
            b2u = button2url.Text;


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
                Client = new DiscordRpcClient(appid);
                Client.Initialize();
                Client.SetPresence(new RichPresence()
                {
                    Details = details,
                    State = status,
                    Assets = new Assets()
                    {
                        LargeImageKey = lik,
                        LargeImageText = lit,
                        SmallImageKey = sik,
                        SmallImageText = sit
                    },
                    Buttons = new DiscordRPC.Button[]
                    {
                    new DiscordRPC.Button() { Label = b1t, Url = b1u },
                    new DiscordRPC.Button() { Label = b2t, Url = b2u }
                    }
                });
                string message = "Presence has been applied.";
                string title = "Custom Presence";
                MessageBox.Show(message, title);
            }
        }

        private void detailsbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (inita == true)
            {
                enabled = false;
                Client.Dispose();
                inita = false;
                string message2 = "Presence has been removed.";
                string title2 = "Custom Presence";
                MessageBox.Show(message2, title2);
            }
            else
            {
                string message = "Please apply a presence first.";
                string title = "Custom Presence";
                MessageBox.Show(message, title);
            }
        }
    }
}
