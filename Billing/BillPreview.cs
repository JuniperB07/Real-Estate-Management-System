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
        ReportParameter[] rp;
        ReportParameter[] rpHeader, rpPG1, rpPG2, rpPG3, rpPG4;

        public BillPreview()
        {
            InitializeComponent();
            Internals.SetFormColors(this);
        }

        private void BillPreview_Load(object sender, EventArgs e)
        {
            ProcessingRequest PR = new ProcessingRequest();
            PR.Show();
            Application.DoEvents();

            InitializeReportViewer();

            FillInvoiceHeader();
            FillInvoicePage1();
            FillInvoicePage2();
            FillInvoicePage3();
            FillInvoicePage4();

            rp = rpHeader
                .Concat(rpPG1)
                .Concat(rpPG2)
                .Concat(rpPG3)
                .Concat(rpPG4)
                .ToArray();

            if (PreviewHelper.PreviewMode == PreviewHelperMode.ExportToPDF)
            {
                ExportToPDF ETPDF = new ExportToPDF();
                ETPDF.ShowDialog();
            }
            else
            {
                rvInvoice.LocalReport.SetParameters(rp);
                rvInvoice.RefreshReport();
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
