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
                new(InvoiceEnums.prmHEADER_BusinessName.ToString(), InvoiceHeader.BusinessName),
                new(InvoiceEnums.prmHEADER_BusinessAddress.ToString(), InvoiceHeader.BusinessAddress),
                new(InvoiceEnums.prmHEADER_BusinessContactInfo.ToString(), InvoiceHeader.BusinessContactInfo),
                new(InvoiceEnums.prmHEADER_BIRInfo.ToString(), InvoiceHeader.BusinessBIRInfo)
                ];
        }

        private void FillInvoicePage1()
        {
            rpPG1 = [
                new(InvoiceEnums.prmPG1_TenantName.ToString(), InvoicePage1.TenantName),
                new(InvoiceEnums.prmPG1_RoomName.ToString(), InvoicePage1.RoomName),
                new(InvoiceEnums.prmPG1_Building.ToString(), InvoicePage1.Building),
                new(InvoiceEnums.prmPG1_BusinessAddress.ToString(), InvoicePage1.BuildingAddress),

                new(InvoiceEnums.prmPG1_InvoiceNumber.ToString(), BHelper.InvoiceNumber),
                new(InvoiceEnums.prmPG1_InvoiceDate.ToString(), InvoicePage1.InvoiceDate.ToString("MMMM d, yyyy")),

                new(InvoiceEnums.prmPG1_BalanceFromPreviousInvoice.ToString(), InvoicePage1.BalanceFromPreviousInvoice.ToString("0,0.00")),
                new(InvoiceEnums.prmPG1_PaymentsReceived.ToString(), InvoicePage1.PaymentsReceived.ToString("0,0.00")),
                new(InvoiceEnums.prmPG1_RemainingBalance.ToString(), InvoicePage1.RemainingBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG1_UtilitiesDueDate.ToString(), InvoicePage1.UtilitiesDueDate.ToString("MMMM d, yyyy")),
                new(InvoiceEnums.prmPG1_RentalDueDate.ToString(), InvoicePage1.RentalDueDate.ToString("MMMM d, yyyy")),
                new(InvoiceEnums.prmPG1_InternetDueDate.ToString(), InvoicePage1.InternetDueDate.ToString("MMMM d, yyyy")),
                new(InvoiceEnums.prmPG1_UtilitiesCurrentCharges.ToString(), InvoicePage1.UtilitiesCurrentCharges.ToString("0,0.00")),
                new(InvoiceEnums.prmPG1_RentalCurrentCharges.ToString(), InvoicePage1.RentalCurrentCharges.ToString("0,0.00")),
                new(InvoiceEnums.prmPG1_InternetCurrentCharges.ToString(), InvoicePage1.InternetCurrentCharges.ToString("0,0.00")),
                new(InvoiceEnums.prmPG1_TotalCurrentCharges.ToString(), InvoicePage1.TotalCurrentCharges.ToString("0,0.00")),
                new(InvoiceEnums.prmPG1_TotalAmountDue.ToString(), InvoicePage1.TotalAmountDue.ToString("0,0.00"))
                ];
        }
    }
}
