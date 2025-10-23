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
    partial class WaterBill
    {
        private void ResetForm()
        {
            Forms.ClearControlText(Forms.ControlType<TextBox>.Extract(this));
            Forms.ClearControlText(Forms.ControlType<Label>.Extract(this, "lbl"));
        }

        private void FillForm()
        {
            lblDueDate.Text = WaterInvoiceDraft.DueDate.ToString("MMMM d, yyyy");
            lblRemainingBalance.Text = WaterInvoiceDraft.RemainingBalance.ToString("0,0.00");
            lblDeductions.Text = WaterInvoiceDraft.Deductions.ToString("0,0.00");
            lblTotal.Text = WaterInvoiceDraft.Subtotal.ToString("0,0.00");

            if (WaterInvoiceDraft.PreviousReading > 0)
                txtPrevious.Text = WaterInvoiceDraft.PreviousReading.ToString();
            else
            {
                if (WaterInvoiceDraft.LastPresentReading > 0)
                    txtPrevious.Text = WaterInvoiceDraft.LastPresentReading.ToString();
                else
                    txtPrevious.Text = "0";
            }

            txtPresent.Text = WaterInvoiceDraft.PresentReading.ToString();
            lblCurrentCharge.Text = WaterInvoiceDraft.CurrentCharge.ToString("0,0.00");

            if (WaterInvoiceDraft.Consumption == -1)
                lblConsumption.Text = "0";
            else
                lblConsumption.Text = WaterInvoiceDraft.Consumption.ToString();
        }
    }
}
