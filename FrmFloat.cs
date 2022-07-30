using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace PCSetupTool
{

    public partial class FrmFloat : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #region Capture None Boaderstyle Winform
        //Using for capturing the None Boaderstyle Winform
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        #endregion
         public  FrmMain frmMain = null;
        private Point _frmPoint;
        public FrmFloat()
        {

            InitializeComponent();
            this.MouseDown += MainFrm_MouseDown;
            this.MouseMove += MainFrm_MouseMove;
            _frmPoint = new Point();
        }


        //protected override void OnMouseDown(MouseEventArgs e)
        //{
        //    base.OnMouseDown(e);
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain.WindowState = FormWindowState.Normal;
            frmMain.Show();
            this.Hide();
        }
        void MainFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-_frmPoint.X, -_frmPoint.Y);
                Location = myPosittion;
            }
        }

        void MainFrm_MouseDown(object sender, MouseEventArgs e)
        {
            _frmPoint.X = e.X;
            _frmPoint.Y = e.Y;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain.Dispose();
            frmMain.Close();
            this.Dispose();
            this.Close();
        }

    }
}
