using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SocialsPost
{
    public partial class Form1 : Form
    {
        bool isFormMax = false;

        public Form1()
        {
            InitializeComponent();

            pnlPublish.Visible = true;
            pnlSchedule.Visible = false;
            pnlOptions.Visible = false;
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNormalMax_Click(object sender, EventArgs e)
        {
            if (isFormMax)
            {
                WindowState = FormWindowState.Normal;
                isFormMax = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                isFormMax = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExitApp_MouseEnter(object sender, EventArgs e)
        {
            btnExitApp.BackColor = Color.FromArgb(2, 64, 89);
            btnExitApp.Image = Image.FromFile("D:/Documents/Design/Me/Helper images/Helper icons/PNG/Cross (red).png");
        }

        private void btnExitApp_MouseLeave(object sender, EventArgs e)
        {
            btnExitApp.BackColor = Color.FromArgb(3, 120, 166);
            btnExitApp.Image = Image.FromFile("D:/Documents/Design/Me/Helper images/Helper icons/PNG/Cross (black).png");
        }

        private void btnNormalMax_MouseEnter(object sender, EventArgs e)
        {
            btnNormalMax.BackColor = Color.FromArgb(2, 64, 89);
            btnNormalMax.Image = Image.FromFile("D:/Documents/Design/Me/Helper images/Helper icons/PNG/Normal & Maxmize (white).png");
        }

        private void btnNormalMax_MouseLeave(object sender, EventArgs e)
        {
            btnNormalMax.BackColor = Color.FromArgb(3, 120, 166);
            btnNormalMax.Image = Image.FromFile("D:/Documents/Design/Me/Helper images/Helper icons/PNG/Normal & Maxmize (black).png");
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(2, 64, 89);
            btnMinimize.Image = Image.FromFile("D:/Documents/Design/Me/Helper images/Helper icons/PNG/Minimize (white).png");
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(3, 120, 166);
            btnMinimize.Image = Image.FromFile("D:/Documents/Design/Me/Helper images/Helper icons/PNG/Minimize (black).png");
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(2, 64, 89);
            btnSettings.ForeColor = Color.White;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(3, 120, 166);
            btnSettings.ForeColor = Color.Black;
        }

        private void btnSchedule_MouseEnter(object sender, EventArgs e)
        {
            btnSchedule.BackColor = Color.FromArgb(2, 64, 89);
            btnSchedule.ForeColor = Color.White;
        }

        private void btnSchedule_MouseLeave(object sender, EventArgs e)
        {
            btnSchedule.BackColor = Color.FromArgb(3, 120, 166);
            btnSchedule.ForeColor = Color.Black;
        }

        private void btnPublish_MouseEnter(object sender, EventArgs e)
        {
            btnPublish.BackColor = Color.FromArgb(2, 64, 89);
            btnPublish.ForeColor = Color.White;
        }

        private void btnPublish_MouseLeave(object sender, EventArgs e)
        {
            btnPublish.BackColor = Color.FromArgb(3, 120, 166);
            btnPublish.ForeColor = Color.Black;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = true;
            pnlPublish.Visible = false;
            pnlSchedule.Visible = false;
        }

        private void btnSchedule_Click_1(object sender, EventArgs e)
        {
            pnlSchedule.Visible = true;
            pnlPublish.Visible = false;
            pnlOptions.Visible = false;
        }

        private void btnPublish_Click_1(object sender, EventArgs e)
        {
            pnlPublish.Visible = true;
            pnlSchedule.Visible = false;
            pnlOptions.Visible = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String strPageCode = client.DownloadString("https://graph.facebook.com/facebook/picture?redirect=false");

            richTextBox1.Text = strPageCode;
        }
    }
}
