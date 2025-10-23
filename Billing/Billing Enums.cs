using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Billing
{
    internal enum InvoiceStatuses
    {
        Unknown=-1,
        PAID,
        UNPAID,
        PARTIAL,
        TRANSFERRED
    }

    internal enum InvoiceTypes
    {
        WATER,
        ELECTRICITY,
        RENTAL,
        INTERNET,
        Unknown = -1
    }

    internal enum PenaltyStatuses
    {
        Unknown = -1,
        PAID,
        UNPAID,
        PARTIAL
    }
}
