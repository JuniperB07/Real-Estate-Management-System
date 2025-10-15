using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Payments
{
    internal static class PaymentsHelper
    {
        internal static PaymentBillTypes PaymentBillType { get; set; }
    }

    internal enum PaymentBillTypes
    {
        None,
        Water,
        Electricity,
        Rental,
        Internet
    }
}
