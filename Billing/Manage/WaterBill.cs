using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NET8.Utilities;
using JunX.NET8.WinForms;

namespace Real_Estate_Management_System.Billing.Manage
{
    public partial class WaterBill : Form
    {
        Dialogs.MSGBox_OK MBOK;
        WaterInvoice WaterInvoiceDraft;

        public WaterBill()
        {
            InitializeComponent();
            MBOK = new Dialogs.MSGBox_OK();
            WaterInvoiceDraft = new WaterInvoice();
        }

        private void Manage_WaterBill_Load(object sender, EventArgs e)
        {
            MBOK = new Dialogs.MSGBox_OK();
            WaterInvoiceDraft = BHelper.NewWaterInvoice.Clone();

            ResetForm();
            FillForm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!WaterInvoiceDraft.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Invalid input detected.\nPlease make sure all inputs are valid.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            BHelper.NewWaterInvoice = WaterInvoiceDraft;

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Water invoice information saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            Close();
        }

        private void WaterBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPresent.Text) || string.IsNullOrWhiteSpace(txtPrevious.Text))
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please enter a valid reading.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            if(!double.TryParse(txtPresent.Text, out _) || !double.TryParse(txtPrevious.Text, out _))
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please enter a valid reading.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            WaterInvoiceDraft.PresentReading = Convert.ToDouble(txtPresent.Text);
            WaterInvoiceDraft.PreviousReading = Convert.ToDouble(txtPrevious.Text);

            lblCurrentCharge.Text = WaterInvoiceDraft.CurrentCharge.ToString("0,0.00");
            lblTotal.Text = WaterInvoiceDraft.Subtotal.ToString("0,0.00");

            if (WaterInvoiceDraft.Consumption == -1)
                lblConsumption.Text = "0";
            else
                lblConsumption.Text = WaterInvoiceDraft.Consumption.ToString();
        }
    }
}
