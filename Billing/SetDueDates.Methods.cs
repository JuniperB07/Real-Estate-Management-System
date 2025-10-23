using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Billing
{
    partial class SetDueDates
    {
        private void ResetForm()
        {
            Forms.SetDateTimePickerMinDate(new DateTimePicker[]
            {
                dtpInternetDueDate,
                dtpRentalDueDate,
                dtpUtilitiesDueDate }, DateTime.Now.Date.AddDays(-1));
            Forms.SetDateTimePickerMaxDate(new DateTimePicker[]
            {
                dtpInternetDueDate,
                dtpRentalDueDate,
                dtpUtilitiesDueDate }, DateTime.Now.Date.AddYears(1));
        }

        private void FillForm()
        {
            dtpUtilitiesDueDate.Value = BHelper.NewWaterInvoice.DueDate;
            dtpRentalDueDate.Value = BHelper.NewRentalInvoice.DueDate;
            dtpInternetDueDate.Value = BHelper.NewInternetInvoice.DueDate;
        }
    }
}
