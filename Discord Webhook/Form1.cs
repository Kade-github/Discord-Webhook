using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Webhook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
        private void icon_TextChanged(object sender, EventArgs e)
        {
            string Icon = icon.Text;
            pictureBox1.Load(Icon);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User = user.Text;
            string Icon = icon.Text;
            string Link = link.Text;
            using (webhook discord = new webhook())
            {
                discord.ProfilePicture = Icon;
                discord.UserName = User;
                discord.WebHook = Link;
                discord.SendMessage(msg.Text);
            }
        }
    }
}
