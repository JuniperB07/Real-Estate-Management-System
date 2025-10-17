using Real_Estate_Management_System.Splash_Screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
    public partial class Splash : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Splash()
        {
            InitializeComponent();
        }

        private void tmrUIUpdater_Tick(object sender, EventArgs e)
        {
            lblLoading.Text = SplashHelper.Splash_LoadingText;
        }

        private void Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void pnlBG_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlBG_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void pnlBG_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pcbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            pnlBG_MouseDown(sender, e);
        }

        private void pcbLogo_MouseMove(object sender, MouseEventArgs e)
        {
            pnlBG_MouseMove(sender, e);
        }

        private void pcbLogo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
