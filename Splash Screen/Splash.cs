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
        public Splash()
        {
            InitializeComponent();
        }

        private void tmrUIUpdater_Tick(object sender, EventArgs e)
        {
            lblLoading.Text = SplashHelper.Splash_LoadingText;
        }
    }
}
