using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoZ.ViewForm
{
    public partial class DiscordLevelUp : Form
    {
        int _typewords = 50;
        int _enterwords = 1000;
        int _allwords = 250;

        int timercount = 3;
        int startcount = 0;
        public void ConfigChecker(SpeedConfig speed)
        {
            switch(speed)
            {
                case SpeedConfig.Fast:
                    _typewords = 50;
                    _enterwords = 1000;
                    _allwords = 250;
                    break;
                case SpeedConfig.Moderate:
                    _typewords = 150;
                    _enterwords = 1500;
                    _allwords = 750;
                    break;
                case SpeedConfig.Slow:
                    _typewords = 200;
                    _enterwords = 2000;
                    _allwords = 750;
                    break;
                default:
                    _typewords = 50;
                    _enterwords = 1000;
                    _allwords = 250;
                    break;
            }
            //MessageBox.Show(string.Format("{0} - {1} - {2}", _typewords.ToString(), _enterwords.ToString(), _allwords.ToString()));
        }
        public enum SpeedConfig
        {
            Fast,
            Moderate,
            Slow,
            Customize
        }
        public DiscordLevelUp()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void AutoTyper_Load(object sender, EventArgs e)
        {
            gunaAdvenceButton1.Text = "[F3] GENERATE" + Environment.NewLine + "RANDOM CHARS.";
        }

        #region WORDS SPLITTER
        private async void StartSplit()
        {
            if (!string.IsNullOrEmpty(txtwords.Text) || txtwords.Text.Length > 0)
            {
                txtwords.Text = txtwords.Text.Replace("\n", String.Empty);
                await SplitWords(txtwords.Text, " ");
                await ShowFormmatedWords();
            }
        }
        //split words code
        List<string> _words = new List<string>();
        private async Task SplitWords(string words, string format)
        {
            string[] storedwords = words.Split(Convert.ToChar(format));
            txtwords.ResetText();
            foreach (string str in storedwords)
                _words.Add(str);

            await Task.CompletedTask;
        }
        private async Task ShowFormmatedWords()
        {
            txtwords.Text = string.Join(Environment.NewLine, _words);

            await Task.CompletedTask;
        }
        #endregion

        private void txtwords_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            gunaLinePanel1.LineColor = Color.FromArgb(71, 247, 226);
        }
        private void txtwords_MouseLeave(object sender, EventArgs e)
        {
            gunaLinePanel1.LineColor = Color.FromArgb(246, 124, 246);
        }

        private void txtwords_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                txtwords.Text = File.ReadAllText(files[0]);
                if(MessageBox.Show("Do you want to format this words per new line?", "Question", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StartSplit();
                }
                else { //do nothing}
                }
            }
        }

        #region generating random words
        private async void StartAndStop(bool? isRunning)
        {
            if (isRunning == true)
                await GenerateRandomWords(1, new Random().Next(8,50));
        }

        async Task GenerateRandomWords(int count, int randomchar)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[randomchar];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(1, chars.Length)];
            }
            var finalString = new String(stringChars);

            txtwords.Text += finalString + Environment.NewLine;
            txtwords.SelectionStart = txtwords.Text.Length;
            txtwords.ScrollToCaret();
            txtwords.Refresh();

            await Task.CompletedTask;
        }

        #endregion
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartAndStop(true);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtwords.Text = txtwords.Text.Remove(txtwords.Text.LastIndexOf(Environment.NewLine));
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtwords.Text))
            {
                CountWordsLine();
                EnableAndDisable(false);
                if (isTimer.Checked == true)
                {
                    if (countpanel.Visible == false)
                        countpanel.Show();

                    timer2.Start();
                }
                else
                {
                    SendInterval.Start();
                }
            }
            else
            {
                MessageBox.Show("Null");
            }
        }

        #region Enter the words and delete after.
        string[] lines;
        int linescount = 0;
        int cc = -1;
        private async void SendInterval_Tick(object sender, EventArgs e)
        {
            if (cc == linescount)
            {
                SendInterval.Stop();
                cc = -1;
                EnableAndDisable(true);
            }
            else
            {
                cc++;
                if (cc != linescount)
                {
                    lbltypingwords.Text = lines[cc].ToString();

                    await SendWords();
                }
                else
                {
                    SendInterval.Stop();
                    cc = -1;
                    EnableAndDisable(true);
                }
            }
        }
        private bool CountWordsLine()
        {
            lines = txtwords.Text.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None);

            linescount = lines.Count();
            return true;
        }

        private async Task SendWords()
        {
            SendKeys.Send(this.lbltypingwords.Text);
            Thread.Sleep(_typewords);
            SendKeys.Send("{ENTER}");
            Thread.Sleep(_enterwords);
            if (isDelete.Checked == true)
            {
                SendKeys.Send("{UP}");
                Thread.Sleep(_allwords);
                SendKeys.Send("^a");
                Thread.Sleep(_allwords);
                SendKeys.Send("{BACKSPACE}");
                Thread.Sleep(_allwords);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(_allwords);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(_allwords);
            }
            await Task.CompletedTask;
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            startcount++;
            int x = Convert.ToInt32(lblcount.Text);
            x--;
            lblcount.Text = x.ToString();
            if (startcount == timercount)
            {
                timer2.Stop();
                startcount = 0;
                lblcount.Text = timercount.ToString();

                await Runnnnn();

                await Task.Delay(200);
                SendInterval.Start();
            }
        }

        private async Task Runnnnn()
        {
            countpanel.Hide();
            timer2.Dispose();

            await Task.CompletedTask;
        }

        #endregion

        private void stopButton_Click(object sender, EventArgs e)
        {
            SendInterval.Stop();
            EnableAndDisable(true);
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaRadioButton grb = (Guna.UI.WinForms.GunaRadioButton)sender;

            if (grb.Text == "Fast")
                ConfigChecker(SpeedConfig.Fast);
            else if (grb.Text == "Moderate")
                ConfigChecker(SpeedConfig.Moderate);
            else if (grb.Text == "Slow")
                ConfigChecker(SpeedConfig.Slow);
            else if (grb.Text == "Customize")
                ConfigChecker(SpeedConfig.Customize);
        }

        private void txtcount_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtcount.Text))
            {
               timercount = Convert.ToInt32(txtcount.Text);
               lblcount.Text = timercount.ToString();
            }
        }

        private void txtcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsendinterval_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsendinterval.Text))
            {
                int intervalmultiply = Math.Abs(Convert.ToInt32(txtsendinterval.Text) * 1000);
                SendInterval.Interval = intervalmultiply;
            }
        }

        #region disable and enable properties

        private void EnableAndDisable(bool yesorno)
        {
            txtwords.Enabled = yesorno;
            startButton.Enabled = yesorno;
            gunaAdvenceButton1.Enabled = yesorno;
            gunaAdvenceButton2.Enabled = yesorno;
            txtcount.Enabled = yesorno;
            txtsendinterval.Enabled = yesorno;
            isDelete.Enabled = yesorno;
            isTimer.Enabled = yesorno;
            pictureBox1.Enabled = yesorno;
        }

        #endregion

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdashboard f1 = new frmdashboard();
            f1.Closed += (s, args) => this.Dispose();
            f1.Show();
        }
    }
}
