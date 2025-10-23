using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Billing
{
    internal static class Methods
    {
        /// <summary>
        /// Generates a unique invoice number for the specified tenant using a configured prefix and timestamp.
        /// </summary>
        /// <param name="TenantID">The tenant ID to embed in the invoice number.</param>
        /// <returns>
        /// A string representing the generated invoice number, composed of:
        /// <list type="bullet">
        ///   <item><description>The configured prefix from <c>BillingConfig.InvoiceNumberPrefix</c>.</description></item>
        ///   <item><description>The tenant ID.</description></item>
        ///   <item><description>The current timestamp in <c>MMddyyyyHHmmss</c> format.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// This method ensures invoice numbers are unique per tenant and timestamp, suitable for tracking and audit purposes.
        /// </remarks>
        internal static string GenerateInvoiceNumber(int TenantID)
        {
            return Configs.Billing.BillingConfig.InvoiceNumberPrefix +
                TenantID.ToString() + 
                DateTime.Now.ToString("MMddyyyyHHmmss");
        }

        /// <summary>
        /// Computes the due date for an invoice based on the configured due date mode, invoice date, tenant, and invoice type.
        /// </summary>
        /// <param name="DueDateMode">The logic mode used to determine the due date (e.g., start-date dependent, fixed day).</param>
        /// <param name="InvoiceDate">The date the invoice is issued or generated.</param>
        /// <param name="TenantID">The tenant ID used for start-date dependent calculations (optional).</param>
        /// <param name="InvoiceType">The type of invoice (e.g., Internet, Rental, Utilities) used for user-defined due dates.</param>
        /// <returns>
        /// A <see cref="DateTime"/> representing the computed due date based on the selected mode and context.
        /// </returns>
        /// <remarks>
        /// The method supports multiple due date strategies:
        /// <list type="bullet">
        ///   <item><description><c>Start_Date_Dependent</c>: aligns due date with tenant's start day.</description></item>
        ///   <item><description><c>First_Day_Of_The_Month</c>: always returns the first day of the next or current month.</description></item>
        ///   <item><description><c>Last_Day_Of_The_Month</c>: returns the final calendar day of the invoice month.</description></item>
        ///   <item><description><c>Fifteenth_Day_Of_The_Month</c>: returns the 15th or next month's 15th if past.</description></item>
        ///   <item><description><c>User_Defined</c>: resolves due date from global config based on invoice type.</description></item>
        /// </list>
        /// The result is capped to the last valid day of the target month to avoid invalid dates.
        /// </remarks>
        internal static DateTime DueDate(Configs.DueDateModes DueDateMode, DateTime InvoiceDate, int TenantID = 0, InvoiceTypes InvoiceType = InvoiceTypes.Unknown)
        {
            if(DueDateMode == Configs.DueDateModes.Start_Date_Dependent)
            {
                DateTime baseDate = new DateTime(InvoiceDate.Year, InvoiceDate.Month, 1);
                DateTime SD = default;
                int targetDay = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.StartDate)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                SD = Convert.ToDateTime(Internals.DBC.Values[0]);

                targetDay = SD.Day;

                if (InvoiceDate.Day > targetDay)
                    baseDate = baseDate.AddMonths(1);

                int maxDay = DateTime.DaysInMonth(baseDate.Year, baseDate.Month);
                targetDay = Math.Min(targetDay, maxDay);

                return new DateTime(baseDate.Year, baseDate.Month, targetDay);
            }
            else if(DueDateMode == Configs.DueDateModes.First_Day_Of_The_Month)
            {
                if (InvoiceDate.Day != 1)
                    return new DateTime(InvoiceDate.AddMonths(1).Year, InvoiceDate.AddMonths(1).Month, 1);
                else
                    return new DateTime(InvoiceDate.Year, InvoiceDate.Month, 1);
            }
            else if(DueDateMode == Configs.DueDateModes.Last_Day_Of_The_Month)
            {
                int maxDay = DateTime.DaysInMonth(InvoiceDate.Year, InvoiceDate.Month);
                return new DateTime(InvoiceDate.Year, InvoiceDate.Month, maxDay);
            }
            else if(DueDateMode == Configs.DueDateModes.Fifteenth_Day_Of_The_Month)
            {
                DateTime baseDate = new DateTime(InvoiceDate.Year, InvoiceDate.Month, 1);
                int targetDay = 15;

                if (InvoiceDate.Day > targetDay)
                    baseDate = baseDate.AddMonths(1);

                int maxDay = DateTime.DaysInMonth(baseDate.Year, baseDate.Month);
                targetDay = Math.Min(targetDay, maxDay);

                return new DateTime(baseDate.Year, baseDate.Month, targetDay);
            }
            else //DueDateMode is User_Defined
            {
                DateTime baseDate = new DateTime(InvoiceDate.Year, InvoiceDate.Month, 1);
                int targetDay = 0;

                if (InvoiceType == InvoiceTypes.WATER || InvoiceType == InvoiceTypes.ELECTRICITY)
                    targetDay = Configs.DueDates.DueDatesConfig.DueDate_Utilities;
                else if (InvoiceType == InvoiceTypes.RENTAL)
                    targetDay = Configs.DueDates.DueDatesConfig.DueDate_Rental;
                else if (InvoiceType == InvoiceTypes.INTERNET)
                    targetDay = Configs.DueDates.DueDatesConfig.DueDate_Internet;
                else
                    targetDay = 1;

                if (InvoiceDate.Day > targetDay)
                    baseDate = baseDate.AddMonths(1);

                int maxDay = DateTime.DaysInMonth(baseDate.Year, baseDate.Month);
                targetDay = Math.Min(targetDay, maxDay);

                return new DateTime(baseDate.Year, baseDate.Month, targetDay);
            }
        }
    }
}
