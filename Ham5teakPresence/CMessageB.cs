using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ham5teakPresence
{
    public partial class CMessageB : Form
    {

        public CMessageB()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CMessageB_Load(object sender, EventArgs e)
        {

        }


        protected override void OnShown(EventArgs e)
        {

            if (Properties.Settings.Default.dark == true)
            {

                button1.TabStop = true;
                button1.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderSize = 0;
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
            button1.BackColor = btn;
            button1.ForeColor = TextColor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
