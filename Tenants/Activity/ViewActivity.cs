using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Tenants.Activity
{
    public partial class ViewActivity : Form
    {
        private Form TenantForm;
        private InvoiceHistory IH;
        private PaymentHistory PH;
        private AdvancesCredits AC;
        private Complaints C;
        private Penalties P;
        private Others O;

        public ViewActivity(Form Parent)
        {
            InitializeComponent();
            TenantForm = Parent;
            IH = new InvoiceHistory(this, btnInvoiceHistory);
            PH = new PaymentHistory(this, btnPaymentHistory);
            AC = new AdvancesCredits(this, btnAdvancesCredits);
            C = new Complaints(this, btnComplaints);
            P = new Penalties(this, btnPenalties);
            O = new Others(this, btnOthers);
        }

        private void ViewActivity_Load(object sender, EventArgs e)
        {
            #region SET FORM POSITION
            Owner = TenantForm;
            Location = new Point(
                TenantForm.Left + (TenantForm.Width - this.Width) / 2,
                TenantForm.Top);
            #endregion
        }

        private void btnInvoiceHistory_Click(object sender, EventArgs e)
        {
            if (IH.IsDisposed || !IH.Visible)
                IH = new InvoiceHistory(this, btnInvoiceHistory);
            IH.Show();

            if (!ActivityHelper.AreClosed(new Form[] { PH, AC, C, P, O }, out List<Form> Visibles))
                foreach (Form V in Visibles)
                    V.Close();
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            if (PH.IsDisposed || !PH.Visible)
                PH = new PaymentHistory(this, btnPaymentHistory);
            PH.Show();

            if (!ActivityHelper.AreClosed(new Form[] { IH, AC, C, P, O }, out List<Form> Visibles))
                foreach (Form V in Visibles)
                    V.Close();
        }

        private void btnAdvancesCredits_Click(object sender, EventArgs e)
        {
            if (AC.IsDisposed || !AC.Visible)
                AC = new AdvancesCredits(this, btnAdvancesCredits);
            AC.Show();

            if (!ActivityHelper.AreClosed(new Form[] { IH, PH, C, P, O }, out List<Form> Visibles))
                foreach (Form V in Visibles)
                    V.Close();
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            if (C.IsDisposed || !C.Visible)
                C = new Complaints(this, btnComplaints);
            C.Show();

            if (!ActivityHelper.AreClosed(new Form[] { IH, PH, AC, P, O }, out List<Form> Visibles))
                foreach (Form V in Visibles)
                    V.Close();
        }

        private void btnPenalties_Click(object sender, EventArgs e)
        {
            if (P.IsDisposed || !P.Visible)
                P = new Penalties(this, btnPenalties);
            P.Show();

            if (!ActivityHelper.AreClosed(new Form[] { IH, PH, AC, C, O }, out List<Form> Visibles))
                foreach (Form V in Visibles)
                    V.Close();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            if (O.IsDisposed || !O.Visible)
                O = new Others(this, btnOthers);
            O.Show();

            if (!ActivityHelper.AreClosed(new Form[] { IH, PH, AC, C, P }, out List<Form> Visibles))
                foreach (Form V in Visibles)
                    V.Close();
        }
    }
}
