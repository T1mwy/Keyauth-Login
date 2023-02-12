using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Cookies_Loader_Base
{
    public partial class Home : Form
    {
        #region Rounded Form Corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );
        #endregion

        #region Initialize Form
        public Home()
        {
            InitializeComponent();

            #region Set Rounded Form Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            #endregion
        }
        #endregion

        #region Injector Modules
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0x0;
        private const int SW_SHOW = 0x5;
        #endregion

        #region Form Load
        private void LaunchForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Close Button
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2500);
            Environment.Exit(0);
        }
        #endregion

        #region Download Button Click
        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion                                                                            

        #region Uninstall Menu Button
        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Launch Menu Button
        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
