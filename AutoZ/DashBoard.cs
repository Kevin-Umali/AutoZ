using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoZ
{
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("https://discordapp.com/invite/Ewx7Nhz");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/SemiiKulot");
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Keumjoh");
        }

        private void gunaShadowPanel1_Click(object sender, EventArgs e)
        {
            //AUTO CLICKER
            this.Hide();
            ViewForm.AutoClicker f1 = new ViewForm.AutoClicker();
            f1.Closed += (s, args) => this.Dispose();
            f1.Show();
        }

        private void gunaShadowPanel2_Click(object sender, EventArgs e)
        {
            //AUTO TYPER
        }

        private void gunaShadowPanel3_Click(object sender, EventArgs e)
        {
            //DISCORD LEVEL UP
            this.Hide();
            ViewForm.DiscordLevelUp f1 = new ViewForm.DiscordLevelUp();
            f1.Closed += (s, args) => this.Dispose();
            f1.Show();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
