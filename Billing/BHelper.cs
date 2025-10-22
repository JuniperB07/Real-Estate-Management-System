using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Billing
{
    internal static class BHelper
    {
        internal static InvoiceMetadata NewInvoice { get; set; }
        internal static int TenantID { get; set; }

        internal static bool IncludeInternet => Configs.Billing.BillingConfig.IncludeInternet;
        internal static string TenantName
        {
            get
            {
                if (!(TenantID > 0))
                    return "";

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.FullName)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
    }
}
