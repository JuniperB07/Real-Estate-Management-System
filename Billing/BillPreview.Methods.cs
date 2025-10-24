using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;

namespace Real_Estate_Management_System.Billing
{
    partial class BillPreview
    {
        private void InitializeReportViewer()
        {
            rvInvoice.Dock = DockStyle.Fill;
            rvInvoice.LocalReport.ReportPath = @"RDLCs\Invoice.rdlc";
            rvInvoice.SetDisplayMode(DisplayMode.PrintLayout);
            rvInvoice.RefreshReport();
            Controls.Add(rvInvoice);
        }

        private void FillInvoiceHeader()
        {

        }
    }
}
