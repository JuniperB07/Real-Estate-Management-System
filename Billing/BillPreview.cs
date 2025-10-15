using Microsoft.Reporting.WinForms;
using Real_Estate_Management_System.Billing.Helper;
using Real_Estate_Management_System.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ProcessingRequest PR = new ProcessingRequest();
            PR.Show();
            Application.DoEvents();

            if (PreviewHelper.PreviewMode == PreviewHelperMode.ExportToPDF)
            {
                ExportToPDF ETPDF = new ExportToPDF();
                ETPDF.ShowDialog();
            }
            PR.Close();
        }

        private void BillPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
