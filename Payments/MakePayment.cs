using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Payments
{
    public partial class MakePayment : Form
    {
        private const string DEFAULT_TEXT = "Real Estate Management System - Make Payment [";

        public MakePayment()
        {
            InitializeComponent();

            //SET pnlHeader Image
            switch (PaymentsHelper.PaymentBillType)
            {
                case PaymentBillTypes.Water:
                    pnlHeader.BackgroundImage = Properties.Resources.REMS_MAKE_PAYMENT_WATER;
                    Text = DEFAULT_TEXT + "WATER]";
                    lblHeader.Text = "MAKE PAYMENT:\nWATER BILL";
                    break;
                case PaymentBillTypes.Electricity:
                    pnlHeader.BackgroundImage = Properties.Resources.REMS_MAKE_PAYMENT_ELECTRICITY;
                    Text = DEFAULT_TEXT + "ELECTRICITY]";
                    lblHeader.Text = "MAKE PAYMENT:\nELECTRICITY BILL";
                    break;
                case PaymentBillTypes.Rental:
                    pnlHeader.BackgroundImage = Properties.Resources.REMS_MAKE_PAYMENT_RENTAL;
                    Text = DEFAULT_TEXT + "RENTAL]";
                    lblHeader.Text = "MAKE PAYMENT:\nRENTAL BILL";
                    break;
                case PaymentBillTypes.Internet:
                    pnlHeader.BackgroundImage = Properties.Resources.REMS_MAKE_PAYMENT_INTERNET;
                    Text = DEFAULT_TEXT + "INTERNET]";
                    lblHeader.Text = "MAKE PAYMENT:\nINTERNET BILL";
                    break;
                default:
                    pnlHeader.BackgroundImage = null;
                    Text = DEFAULT_TEXT + "]";
                    break;
            }
        }

        private void MakePayment_Load(object sender, EventArgs e)
        {

        }
    }
}
