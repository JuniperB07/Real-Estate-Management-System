using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Billing.Manage
{
    partial class ElectricityBill
    {
        private void ResetForm()
        {
            Forms.ClearControlText(Forms.ControlType<Label>.Extract(this, "lbl"));
            Forms.ClearControlText(Forms.ControlType<TextBox>.Extract(this));
        }

        private void FillForm()
        {
            if (ElectricityInvoiceDraft.PreviousReading > 0)
                txtPrevious.Text = ElectricityInvoiceDraft.PreviousReading.ToString();
            else
                txtPrevious.Text = ElectricityInvoiceDraft.LastPresentReading.ToString();

            if (ElectricityInvoiceDraft.Consumption != -1)
                lblConsumption.Text = ElectricityInvoiceDraft.Consumption.ToString();
            else
                lblConsumption.Text = "0";

            lblDueDate.Text = ElectricityInvoiceDraft.DueDate.ToString("MMMM d, yyyy");
            txtPresent.Text = ElectricityInvoiceDraft.PresentReading.ToString();
            lblCurrentCharge.Text = ElectricityInvoiceDraft.CurrentCharge.ToString("0,0.00");
            lblRemainingBalance.Text = ElectricityInvoiceDraft.RemainingBalance.ToString("0,0.00");
            lblDeductions.Text = ElectricityInvoiceDraft.Deductions.ToString("0,0.00");
            lblTotal.Text = ElectricityInvoiceDraft.Subtotal.ToString("0,0.00");
        }
    }
}
