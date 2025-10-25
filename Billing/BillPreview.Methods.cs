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

        private void FillInvoicePage2()
        {
            rpPG2 = [
                new(InvoiceEnums.prmPG2_WaterPreviousBalance.ToString(), InvoicePage2.WaterPreviousBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_WaterPaymentsReceived.ToString(), InvoicePage2.WaterPaymentsReceived.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_WaterRemainingBalance.ToString(), InvoicePage2.WaterRemainingBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_WaterPrevious.ToString(), InvoicePage2.WaterPrevious.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_WaterPresent.ToString(), InvoicePage2.WaterPresent.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_WaterConsumption.ToString(), InvoicePage2.WaterConsumption),
                new(InvoiceEnums.prmPG2_WaterConsumptionCharge.ToString(), InvoicePage2.WaterConsumptionCharge.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_WaterDeductions.ToString(), InvoicePage2.WaterDeductions.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_WaterCurrentCharge.ToString(), InvoicePage2.WaterCurrentCharges.ToString("0,0.00")),

                new(InvoiceEnums.prmPG2_ElectricityPreviousBalance.ToString(), InvoicePage2.ElectricityPreviousBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_ElectricityPaymentsReceived.ToString(), InvoicePage2.ElectricityPaymentsReceived.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_ElectricityRemainingBalance.ToString(), InvoicePage2.ElectricityRemainingBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_ElectricityPrevious.ToString(), InvoicePage2.ElectricityPrevious.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_ElectricityPresent.ToString(), InvoicePage2.ElectricityPresent.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_ElectricityConsumption.ToString(), InvoicePage2.ElectricityConsumption),
                new(InvoiceEnums.prmPG2_ElectricityConsumptionCharge.ToString(), InvoicePage2.ElectricityConsumptionCharge.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_ElectricityDeductions.ToString(), InvoicePage2.ElectricityDeductions.ToString("0,0.00")),
                new(InvoiceEnums.prmPG2_ElectricityCurrentCharge.ToString(), InvoicePage2.ElectricityCurrentCharges.ToString("0,0.00"))
                ];
        }

        private void FillInvoicePage3()
        {
            rpPG3 = [
                new(InvoiceEnums.prmPG3_RentalPreviousBalance.ToString(), InvoicePage3.RentalPreviousBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_RentalPaymentsReceived.ToString(), InvoicePage3.RentalPaymentsReceived.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_RentalRemainingBalance.ToString(), InvoicePage3.RentalRemainingBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_RentalMonthlyRent.ToString(), InvoicePage3.RentalMonthlyRent.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_RentalDeductions.ToString(), InvoicePage3.RentalDeductions.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_RentalCurrentCharge.ToString(), InvoicePage3.RentalCurrentCharges.ToString("0,0.00")),

                new(InvoiceEnums.prmPG3_InternetPreviousBalance.ToString(), InvoicePage3.InternetPreviousBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_InternetPaymentsReceived.ToString(), InvoicePage3.InternetPaymentsReceived.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_InternetRemainingBalance.ToString(), InvoicePage3.InternetRemainingBalance.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_InternetPlanAvailed.ToString(), InvoicePage3.InternetPlanAvailed),
                new(InvoiceEnums.prmPG3_InternetSubscriptionCharge.ToString(), InvoicePage3.InternetSubscriptionCharge.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_InternetDeductions.ToString(), InvoicePage3.InternetDeductions.ToString("0,0.00")),
                new(InvoiceEnums.prmPG3_InternetCurrentCharge.ToString(), InvoicePage3.InternetCurrentCharges.ToString("0,0.00"))
                ];
        }

        private void FillInvoicePage4()
        {
            rpPG4 = [
                new(InvoiceEnums.prmPG4_TotalUtilitiesCharge.ToString(), InvoicePage4.TotalUtilitiesCharges.ToString("0,0.00"))
                ];
        }
    }
}
