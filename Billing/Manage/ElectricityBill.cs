using JunX.NET8.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NET8.WinForms;

namespace Real_Estate_Management_System.Billing.Manage
{
    public partial class ElectricityBill : Form
    {
        Dialogs.MSGBox_OK MBOK;
        ElectricityInvoice ElectricityInvoiceDraft;

        public ElectricityBill()
        {
            InitializeComponent();
        }

        private void ElectricityBill_Load(object sender, EventArgs e)
        {
            MBOK = new Dialogs.MSGBox_OK();
            ElectricityInvoiceDraft = BHelper.NewElectricityInvoice.Clone();

            ResetForm();
            FillForm();
        }

        private void ElectricityBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPresent.Text) || string.IsNullOrWhiteSpace(txtPrevious.Text))
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please enter a valid reading.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            if (!double.TryParse(txtPresent.Text, out _) || !double.TryParse(txtPrevious.Text, out _))
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please enter a valid reading.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            ElectricityInvoiceDraft.PreviousReading = Convert.ToDouble(txtPrevious.Text);
            ElectricityInvoiceDraft.PresentReading = Convert.ToDouble(txtPresent.Text);

            lblCurrentCharge.Text = ElectricityInvoiceDraft.CurrentCharge.ToString("0,0.00");
            lblTotal.Text = ElectricityInvoiceDraft.Subtotal.ToString("0,0.00");

            if (ElectricityInvoiceDraft.Consumption != -1)
                lblConsumption.Text = ElectricityInvoiceDraft.Consumption.ToString();
            else
                lblConsumption.Text = "0";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!ElectricityInvoiceDraft.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Invalid input detected.\nPlease make sure all inputs are valid.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            BHelper.NewElectricityInvoice = ElectricityInvoiceDraft;

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Electricity invoice information saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            Close();
        }
    }
}
