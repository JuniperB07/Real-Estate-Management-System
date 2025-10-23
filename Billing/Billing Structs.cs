using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using Org.BouncyCastle.Asn1.Mozilla;

namespace Real_Estate_Management_System.Billing
{
    internal struct DueDatesMetadata
    {
        public DateTime UtilitiesDueDate { get; set; }
        public DateTime RentalDueDate { get; set; }
        public DateTime InternetDueDate { get; set; }

        public DueDatesMetadata(
            DateTime SetUtilitiesDueDate = default,
            DateTime SetRentalDueDate = default,
            DateTime SetInternetDueDate = default)
        {
            UtilitiesDueDate = SetUtilitiesDueDate;
            RentalDueDate = SetRentalDueDate;
            InternetDueDate = SetInternetDueDate;
        }

        public bool IsValid()
        {
            return
                UtilitiesDueDate != default &&
                RentalDueDate != default &&
                InternetDueDate != default;
        }
    }
}
