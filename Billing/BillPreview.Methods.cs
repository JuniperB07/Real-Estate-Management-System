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
            rpHeader = [
                new("prmHEADER_BusinessName", InvoiceHeader.BusinessName),
                new("prmHEADER_BusinessAddress", InvoiceHeader.BusinessAddress),
                new("prmHEADER_BusinessContactInfo", InvoiceHeader.BusinessContactInfo),
                new("prmHEADER_BIRInfo", InvoiceHeader.BusinessBIRInfo)
                ];
        }

        private void FillInvoicePage1()
        {
            rpPG1 = [
                new("prmPG1_TenantName", InvoicePage1.TenantName),
                new("prmPG1_RoomName", InvoicePage1.RoomName),
                new("prmPG1_Building", InvoicePage1.Building),
                new("prmPG1_BuildingAddress", InvoicePage1.BuildingAddress),

                new("prmPG1_InvoiceNumber", BHelper.InvoiceNumber),
                new("prmPG1_InvoiceDate", InvoicePage1.InvoiceDate.ToString("MMMM d, yyyy")),

                new("prmPG1_BalanceFromPreviousInvoice", InvoicePage1.BalanceFromPreviousInvoice.ToString("0,0.00")),
                new("prmPG1_PaymentsReceived", InvoicePage1.PaymentsReceived.ToString("0,0.00")),
                new("prmPG1_RemainingBalance", InvoicePage1.RemainingBalance.ToString("0,0.00")),
                new("prmPG1_UtilitiesDueDate", InvoicePage1.UtilitiesDueDate.ToString("MMMM d, yyyy")),
                new("prmPG1_RentalDueDate", InvoicePage1.RentalDueDate.ToString("MMMM d, yyyy")),
                new("prmPG1_InternetDueDate", InvoicePage1.InternetDueDate.ToString("MMMM d, yyyy")),
                new("prmPG1_UtilitiesCurrentCharges", InvoicePage1.UtilitiesCurrentCharges.ToString("0,0.00")),
                new("prmPG1_RentalCurrentCharges", InvoicePage1.RentalCurrentCharges.ToString("0,0.00")),
                new("prmPG1_InternetCurrentCharges", InvoicePage1.InternetCurrentCharges.ToString("0,0.00")),
                new("prmPG1_TotalCurrentCharges", InvoicePage1.TotalCurrentCharges.ToString("0,0.00")),
                new("prmPG1_TotalAmountDue", InvoicePage1.TotalAmountDue.ToString("0,0.00"))
                ];
        }
    }
}
