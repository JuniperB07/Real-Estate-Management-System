using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Billing.Helper
{
    internal static class PreviewHelper
    {
        internal static PreviewHelperMode PreviewMode { get; set; }
    }

    internal enum PreviewHelperMode
    {
        Preview,
        ExportToPDF
    }
}
