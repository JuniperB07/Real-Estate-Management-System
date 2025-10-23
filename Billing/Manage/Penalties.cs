using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Billing.Manage
{
    public partial class Penalties : Form
    {
        public Penalties()
        {
            InitializeComponent();
        }

        private void Penalties_Load(object sender, EventArgs e)
        {
            dgvPenalties.DataSource = null;

            new SelectCommand<tbpenalties>()
                .Select(tbpenalties.Details)
                .Select(tbpenalties.EnforcementDate).As("Enforcement Date")
                .Select(tbpenalties.PenaltyAmount).As("Penalty Amount")
                .Select(tbpenalties.AmountPaid).As("Amount Paid")
                .Select(tbpenalties.Status)
                .From
                .StartWhere
                    .Where(tbpenalties.TenantID, SQLOperator.Equal, BHelper.TenantID.ToString())
                    .And()
                    .StartGroup(tbpenalties.Status, SQLOperator.Equal, "'" + PenaltyStatuses.UNPAID.ToString() + "'")
                        .Or(tbpenalties.Status, SQLOperator.Equal, "'" + PenaltyStatuses.PARTIAL.ToString() + "'")
                    .EndGroup
                .EndWhere
                .ExecuteDataSet(Internals.DBC);
            dgvPenalties.DataSource = Internals.DBC.DataSet.Tables[0];
        }

        private void Penalties_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
