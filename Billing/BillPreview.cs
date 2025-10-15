using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Real_Estate_Management_System.Billing
{
    public partial class BillPreview : Form
    {
        ReportViewer rvInvoice = new ReportViewer();

        public BillPreview()
        {
            InitializeComponent();
            Internals.SetFormColors(this);

            //Initialize ReportViewer 'rvInvoice'
            rvInvoice.Dock = DockStyle.Fill;
            rvInvoice.LocalReport.ReportPath = @"RDLCs\Invoice.rdlc";
            rvInvoice.SetDisplayMode(DisplayMode.PrintLayout);
            rvInvoice.RefreshReport();
            Controls.Add(rvInvoice);
        }

        private void BillPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
