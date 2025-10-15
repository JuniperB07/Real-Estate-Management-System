using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NET8.WinForms;
using Real_Estate_Management_System.Billing.Helper;

namespace Real_Estate_Management_System.Billing
{
    public partial class ExportToPDF : Form
    {
        public ExportToPDF()
        {
            InitializeComponent();
            Internals.SetFormColors(this);

        }

        private void ExportToPDF_Load(object sender, EventArgs e)
        {
            
        }
    }
}
