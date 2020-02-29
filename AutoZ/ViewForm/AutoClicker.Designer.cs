namespace AutoZ.ViewForm
{
    partial class AutoClicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.toppanel = new System.Windows.Forms.Panel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.startButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.stopButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblpos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minWait = new Guna.UI.WinForms.GunaLineTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.maxWait = new Guna.UI.WinForms.GunaLineTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxClicksBetweenMovement = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minClicksBetweenMovement = new Guna.UI.WinForms.GunaLineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numMouseClicks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.toppanel.Controls.Add(this.gunaControlBox3);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Controls.Add(this.gunaControlBox2);
            this.toppanel.Controls.Add(this.gunaControlBox1);
            this.toppanel.Controls.Add(this.pictureBox2);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(379, 32);
            this.toppanel.TabIndex = 2;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Animated = true;
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(244, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 32);
            this.gunaControlBox3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(50, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "AutoZ / Auto Clicker";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Animated = true;
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(289, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 32);
            this.gunaControlBox2.TabIndex = 3;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.CustomClick = true;
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(334, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 32);
            this.gunaControlBox1.TabIndex = 2;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // startButton
            // 
            this.startButton.AnimationHoverSpeed = 0.07F;
            this.startButton.AnimationSpeed = 0.03F;
            this.startButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(109)))), ((int)(((byte)(246)))));
            this.startButton.BorderColor = System.Drawing.Color.Black;
            this.startButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.startButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.startButton.CheckedForeColor = System.Drawing.Color.White;
            this.startButton.CheckedImage = null;
            this.startButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startButton.FocusedColor = System.Drawing.Color.Empty;
            this.startButton.Font = new System.Drawing.Font("Trebuchet MS", 13.75F);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.startButton.Image = null;
            this.startButton.ImageSize = new System.Drawing.Size(20, 20);
            this.startButton.LineColor = System.Drawing.Color.Transparent;
            this.startButton.Location = new System.Drawing.Point(12, 292);
            this.startButton.Name = "startButton";
            this.startButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.startButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.startButton.OnHoverImage = null;
            this.startButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.startButton.OnPressedColor = System.Drawing.Color.Black;
            this.startButton.Size = new System.Drawing.Size(171, 42);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "[F1] START";
            this.startButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startButton.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.AnimationHoverSpeed = 0.07F;
            this.stopButton.AnimationSpeed = 0.03F;
            this.stopButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.stopButton.BorderColor = System.Drawing.Color.Black;
            this.stopButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.stopButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.stopButton.CheckedForeColor = System.Drawing.Color.White;
            this.stopButton.CheckedImage = null;
            this.stopButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopButton.FocusedColor = System.Drawing.Color.Empty;
            this.stopButton.Font = new System.Drawing.Font("Trebuchet MS", 13.75F);
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(109)))), ((int)(((byte)(246)))));
            this.stopButton.Image = null;
            this.stopButton.ImageSize = new System.Drawing.Size(20, 20);
            this.stopButton.LineColor = System.Drawing.Color.Transparent;
            this.stopButton.Location = new System.Drawing.Point(196, 292);
            this.stopButton.Name = "stopButton";
            this.stopButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.stopButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.stopButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.stopButton.OnHoverImage = null;
            this.stopButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.stopButton.OnPressedColor = System.Drawing.Color.Black;
            this.stopButton.Size = new System.Drawing.Size(171, 42);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "[F2] STOP";
            this.stopButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // lblpos
            // 
            this.lblpos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpos.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblpos.Location = new System.Drawing.Point(240, 267);
            this.lblpos.Name = "lblpos";
            this.lblpos.Size = new System.Drawing.Size(127, 18);
            this.lblpos.TabIndex = 11;
            this.lblpos.Text = "0 x 0";
            this.lblpos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Minimum Wait (ms)";
            // 
            // minWait
            // 
            this.minWait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.minWait.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minWait.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.minWait.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.minWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.minWait.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(109)))), ((int)(((byte)(246)))));
            this.minWait.LineSize = 2;
            this.minWait.Location = new System.Drawing.Point(157, 88);
            this.minWait.Name = "minWait";
            this.minWait.PasswordChar = '\0';
            this.minWait.Size = new System.Drawing.Size(177, 26);
            this.minWait.TabIndex = 13;
            this.minWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(42, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Configuration.";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(12, 72);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(355, 10);
            this.gunaSeparator1.TabIndex = 15;
            // 
            // maxWait
            // 
            this.maxWait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.maxWait.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxWait.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.maxWait.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maxWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.maxWait.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(109)))), ((int)(((byte)(246)))));
            this.maxWait.LineSize = 2;
            this.maxWait.Location = new System.Drawing.Point(157, 120);
            this.maxWait.Name = "maxWait";
            this.maxWait.PasswordChar = '\0';
            this.maxWait.Size = new System.Drawing.Size(177, 26);
            this.maxWait.TabIndex = 17;
            this.maxWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Maximum Wait (ms)";
            // 
            // maxClicksBetweenMovement
            // 
            this.maxClicksBetweenMovement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxClicksBetweenMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.maxClicksBetweenMovement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxClicksBetweenMovement.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.maxClicksBetweenMovement.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.maxClicksBetweenMovement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.maxClicksBetweenMovement.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.maxClicksBetweenMovement.LineSize = 2;
            this.maxClicksBetweenMovement.Location = new System.Drawing.Point(204, 184);
            this.maxClicksBetweenMovement.Name = "maxClicksBetweenMovement";
            this.maxClicksBetweenMovement.PasswordChar = '\0';
            this.maxClicksBetweenMovement.Size = new System.Drawing.Size(130, 26);
            this.maxClicksBetweenMovement.TabIndex = 21;
            this.maxClicksBetweenMovement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(24, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Max Clicks Before Movement";
            // 
            // minClicksBetweenMovement
            // 
            this.minClicksBetweenMovement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minClicksBetweenMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.minClicksBetweenMovement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minClicksBetweenMovement.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.minClicksBetweenMovement.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.minClicksBetweenMovement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.minClicksBetweenMovement.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.minClicksBetweenMovement.LineSize = 2;
            this.minClicksBetweenMovement.Location = new System.Drawing.Point(204, 152);
            this.minClicksBetweenMovement.Name = "minClicksBetweenMovement";
            this.minClicksBetweenMovement.PasswordChar = '\0';
            this.minClicksBetweenMovement.Size = new System.Drawing.Size(130, 26);
            this.minClicksBetweenMovement.TabIndex = 19;
            this.minClicksBetweenMovement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(24, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Min Clicks Before Movement";
            // 
            // numMouseClicks
            // 
            this.numMouseClicks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numMouseClicks.AutoSize = true;
            this.numMouseClicks.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.numMouseClicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.numMouseClicks.Location = new System.Drawing.Point(12, 267);
            this.numMouseClicks.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.numMouseClicks.Name = "numMouseClicks";
            this.numMouseClicks.Size = new System.Drawing.Size(126, 18);
            this.numMouseClicks.TabIndex = 24;
            this.numMouseClicks.Text = "0 Total Mouse Clicks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.toppanel;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(167, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fast Click Config (1, 1, 1, 99xxxx)";
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(379, 355);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numMouseClicks);
            this.Controls.Add(this.maxClicksBetweenMovement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minClicksBetweenMovement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxWait);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minWait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpos);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.toppanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoZ.Auto Clicker";
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton startButton;
        private Guna.UI.WinForms.GunaAdvenceButton stopButton;
        private System.Windows.Forms.Label lblpos;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox minWait;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLineTextBox maxWait;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox maxClicksBetweenMovement;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox minClicksBetweenMovement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numMouseClicks;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Label label7;
    }
}