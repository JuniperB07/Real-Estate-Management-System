using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Tenants
{
    internal enum TenancyStatuses
    {
        None = -1,
        Active,
        Inactive,
        Terminated,
        Pending
    }

    internal enum RentType
    {
        None = -1,
        Fixed,
        Monthly
    }
}
