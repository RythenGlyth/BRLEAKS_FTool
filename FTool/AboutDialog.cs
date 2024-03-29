﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace FTool
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void rythenglyth_twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/rythenglyth");
        }

        private void brleaks_twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/BRLeaks_");
        }

        private void rythenglyth_discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.me/rythenglyth");
        }

        private void brleaks_discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/kStqmd");
        }

        private void rythenglyth_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC5rt0GnSstKio9NGxPsRFnw");
        }

        private void brleaks_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC_efo0vMP31b3ave84-O5ZQ");
        }

        private void brleaks_instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/itsbrleaks_");
        }

        private void support_discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/x5yxGbr");
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            this.label2.Font = new System.Drawing.Font(Form1.BurbankBigCondensed, 24F);
            this.label_version.Font = new System.Drawing.Font(Form1.CenturyGothic, 12F);
            this.label1.Font = new System.Drawing.Font(Form1.BurbankBigCondensed, 21.75F);
            this.label4.Font = new System.Drawing.Font(Form1.CenturyGothic, 15.75F);
            this.label3.Font = new System.Drawing.Font(Form1.CenturyGothic, 15.75F);
            this.support_discord.Font = new System.Drawing.Font(Form1.BurbankBigCondensed, 20.25F);
            label_version.Text = "Version " + Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
    }
}
