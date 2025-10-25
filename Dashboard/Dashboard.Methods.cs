using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System
{
    partial class Dashboard
    {
        private void ResetDashboard()
        {
            Forms.ClearControlText(new Label[]
            {
                lblUsername,
                lblUnpaidBills,
                lblOverdueBills,
                lblActiveTenants,
                lblBillsIssued,
                lblPaidBills,
                lblReceivables,
                lblRevenue,
                lblExpenses,
                lblProfit });

            lblSummaryHeader.Text = SUMMARY_HEADER + DateTime.Now.ToString("MMMM yyyy").ToUpper();
            Month_FirstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            Month_LastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            Revenue = 0;
            Expenses = 0;
            Profit = 0;
        }

        private void RefreshAllPanels()
        {
            RefreshUnpaidBills();
            RefreshOverdueBills();
            RefreshActiveTenants();
            RefreshBillsIssued();
            RefreshPaidBills();
            RefreshReceivables();
            RefreshRevenue();
            RefreshExpenses();
            RefreshProfit();
        }

        private void RefreshUnpaidBills()
        {
            int UB = 0;

            new SelectCommand<tbinvoices>()
                .Select(tbinvoices.InvoiceID)
                .From
                .StartWhere
                    .Where(tbinvoices.Status, SQLOperator.Equal, "'" + Billing.InvoiceStatuses.UNPAID.ToString() + "'")
                    .Or(tbinvoices.Status, SQLOperator.Equal, "'" + Billing.InvoiceStatuses.PARTIAL.ToString() + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
                UB = Internals.DBC.Values.Count;
            Internals.DBC.CloseReader();

            lblUnpaidBills.Text = UB.ToString();
        }

        private void RefreshOverdueBills()
        {
            int OBs = 0;
            List<string> invoices = new List<string>();
            DateTime dueDate = default;

            new SelectCommand<tbinvoices>()
                .Select(tbinvoices.InvoiceNumber)
                .From
                .StartWhere
                    .Where(tbinvoices.Status, SQLOperator.Equal, "'" + Billing.InvoiceStatuses.UNPAID.ToString() + "'")
                    .Or(tbinvoices.Status, SQLOperator.Equal, "'" + Billing.InvoiceStatuses.PARTIAL.ToString() + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
                invoices = Internals.DBC.Values.ToList();
            else
            {
                lblOverdueBills.Text = OBs.ToString();
                return;
            }

            foreach (string inv in invoices)
            {
                #region Check Water Sub-Invoice
                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.DueDate)
                    .Select(tbwaterinvoice.Status)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                if (Internals.DBC.Values[1] == Billing.InvoiceStatuses.UNPAID.ToString() ||
                    Internals.DBC.Values[1] == Billing.InvoiceStatuses.PARTIAL.ToString())
                {
                    dueDate = Convert.ToDateTime(Internals.DBC.Values[0]);

                    if (DateTime.Now > dueDate)
                        OBs++;
                }
                #endregion

                #region Check Electricity Sub-Invoice
                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.DueDate)
                    .Select(tbelectricityinvoice.Status)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                if (Internals.DBC.Values[1] == Billing.InvoiceStatuses.UNPAID.ToString() ||
                    Internals.DBC.Values[1] == Billing.InvoiceStatuses.PARTIAL.ToString())
                {
                    dueDate = Convert.ToDateTime(Internals.DBC.Values[0]);
                    if (DateTime.Now > dueDate)
                        OBs++;
                }
                #endregion

                #region Check Rental Sub-Invoice
                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.DueDate)
                    .Select(tbrentalinvoice.Status)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                if (Internals.DBC.Values[1] == Billing.InvoiceStatuses.UNPAID.ToString() ||
                    Internals.DBC.Values[1] == Billing.InvoiceStatuses.PARTIAL.ToString())
                {
                    dueDate = Convert.ToDateTime(Internals.DBC.Values[0]);
                    if (DateTime.Now > dueDate)
                        OBs++;
                }
                #endregion

                #region Check Internal Sub-Invoice
                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.DueDate)
                    .Select(tbinternetinvoice.Status)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                if (Internals.DBC.Values[1] == Billing.InvoiceStatuses.UNPAID.ToString() ||
                    Internals.DBC.Values[1] == Billing.InvoiceStatuses.PARTIAL.ToString())
                {
                    dueDate = Convert.ToDateTime(Internals.DBC.Values[0]);
                    if (DateTime.Now > dueDate)
                        OBs++;
                }
                #endregion
            }

            lblOverdueBills.Text = OBs.ToString();
        }

        private void RefreshActiveTenants()
        {
            new SelectCommand<tbtenants>()
                .Select(tbtenants.TenantID)
                .From
                .StartWhere
                    .Where(tbtenants.TenancyStatus, SQLOperator.Equal, "'" + Tenants.TenancyStatuses.Active.ToString() + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
            {
                lblActiveTenants.Text = Internals.DBC.Values.Count.ToString();
                return;
            }
            Internals.DBC.CloseReader();
            lblActiveTenants.Text = "0";
        }

        private void RefreshBillsIssued()
        {
            new SelectCommand<tbinvoices>()
                .Select(tbinvoices.InvoiceID)
                .From
                .StartWhere
                    .WhereBetween(tbinvoices.InvoiceDate, "'" + Month_FirstDay.ToString("yyyy-MM-dd") + "'", "'" + Month_LastDay.ToString("yyyy-MM-dd") + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
                lblBillsIssued.Text = Internals.DBC.Values.Count.ToString();
            else
                lblBillsIssued.Text = "0";
        }

        private void RefreshPaidBills()
        {
            new SelectCommand<tbinvoices>()
                .Select(tbinvoices.InvoiceID)
                .From
                .StartWhere
                    .Where(tbinvoices.Status, SQLOperator.Equal, "'" + Billing.InvoiceStatuses.PAID.ToString() + "'")
                    .And()
                    .Between(tbinvoices.InvoiceDate, "'" + Month_FirstDay.ToString("yyyy-MM-dd") + "'", "'" + Month_LastDay.ToString("yyyy-MM-dd") + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
            {
                lblPaidBills.Text = Internals.DBC.Values.Count.ToString();
                return;
            }
            Internals.DBC.CloseReader();
            lblPaidBills.Text = "0";
        }

        private void RefreshReceivables()
        {
            double Rs = 0;
            List<string> Invoices = new List<string>();

            new SelectCommand<tbinvoices>()
                .Select(tbinvoices.InvoiceNumber)
                .From
                .StartWhere
                    .WhereBetween(tbinvoices.InvoiceDate, "'" + Month_FirstDay.ToString("yyyy-MM-dd") + "'", "'" + Month_LastDay.ToString("yyyy-MM-dd") + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
                Invoices = Internals.DBC.Values.ToList();
            else
            {
                Internals.DBC.CloseReader();
                lblReceivables.Text = Internals.PESO + Rs.ToString("0,0.00");
                return;
            }
            Internals.DBC.CloseReader();

            foreach(string inv in Invoices)
            {
                #region Check Water Sub-Invoice
                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                Rs += Convert.ToDouble(Internals.DBC.Values[0]);
                #endregion

                #region Check Electricity Sub-Invoice
                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                Rs += Convert.ToDouble(Internals.DBC.Values[0]);
                #endregion

                #region Check Rental Sub-Invoice
                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                Rs += Convert.ToDouble(Internals.DBC.Values[0]);
                #endregion

                #region Check Internet Sub-Invoice
                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                Rs += Convert.ToDouble(Internals.DBC.Values[0]);
                #endregion
            }

            lblReceivables.Text = Internals.PESO + Rs.ToString("0,0.00");
        }

        private void RefreshRevenue()
        {
            double Rev = 0;
            List<string> Invoices = new List<string>();

            new SelectCommand<tbinvoices>()
                .Select(tbinvoices.InvoiceNumber)
                .From
                .StartWhere
                    .WhereBetween(tbinvoices.InvoiceDate, "'" + Month_FirstDay.ToString("yyyy-MM-dd") + "'", "'" + Month_LastDay.ToString("yyyy-MM-dd") + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
                Invoices = Internals.DBC.Values.ToList();
            else
            {
                Internals.DBC.CloseReader();
                lblRevenue.Text = Internals.PESO + Rev.ToString("0,0.00");
                return;
            }

            foreach (string inv in Invoices)
            {
                #region Check Water Sub-Invoice
                new SelectCommand<tbwaterinvoice>()
                    .Select(new tbwaterinvoice[]
                    {
                        tbwaterinvoice.Subtotal,
                        tbwaterinvoice.BillBalance,
                        tbwaterinvoice.Status })
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                if (Internals.DBC.Values[2] == Billing.InvoiceStatuses.PAID.ToString())
                    Rev += Convert.ToDouble(Internals.DBC.Values[0]);
                else if (Internals.DBC.Values[2] == Billing.InvoiceStatuses.PARTIAL.ToString())
                    Rev += Convert.ToDouble(Internals.DBC.Values[0]) - Convert.ToDouble(Internals.DBC.Values[1]);
                Internals.DBC.CloseReader();
                #endregion

                #region Check Electricity Sub-Invoice
                new SelectCommand<tbelectricityinvoice>()
                    .Select(new tbelectricityinvoice[]
                    {
                        tbelectricityinvoice.Subtotal,
                        tbelectricityinvoice.BillBalance,
                        tbelectricityinvoice.Status })
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                if (Internals.DBC.Values[2] == Billing.InvoiceStatuses.PAID.ToString())
                    Rev += Convert.ToDouble(Internals.DBC.Values[0]);
                else if (Internals.DBC.Values[2] == Billing.InvoiceStatuses.PARTIAL.ToString())
                    Rev += Convert.ToDouble(Internals.DBC.Values[0]) - Convert.ToDouble(Internals.DBC.Values[1]);
                Internals.DBC.CloseReader();
                #endregion

                #region Check Rental Sub-Invoice
                new SelectCommand<tbrentalinvoice>()
                    .Select(new tbrentalinvoice[]
                    {
                        tbrentalinvoice.Subtotal,
                        tbrentalinvoice.BillBalance,
                        tbrentalinvoice.Status })
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                if (Internals.DBC.Values[2] == Billing.InvoiceStatuses.PAID.ToString())
                    Rev += Convert.ToDouble(Internals.DBC.Values[0]);
                else if (Internals.DBC.Values[2] == Billing.InvoiceStatuses.PARTIAL.ToString())
                    Rev += Convert.ToDouble(Internals.DBC.Values[0]) - Convert.ToDouble(Internals.DBC.Values[1]);
                Internals.DBC.CloseReader();
                #endregion

                #region Check Internet Sub-Invoice
                new SelectCommand<tbinternetinvoice>()
                    .Select(new tbinternetinvoice[]
                    {
                        tbinternetinvoice.Subtotal,
                        tbinternetinvoice.BillBalance,
                        tbinternetinvoice.Status })
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", inv));
                if (Internals.DBC.Values[2] == Billing.InvoiceStatuses.PAID.ToString())
                    Rev += Convert.ToDouble(Internals.DBC.Values[0]);
                else if (Internals.DBC.Values[2] == Billing.InvoiceStatuses.PARTIAL.ToString())
                    Rev += Convert.ToDouble(Internals.DBC.Values[0]) - Convert.ToDouble(Internals.DBC.Values[1]);
                Internals.DBC.CloseReader();
                #endregion
            }

            Revenue = Rev;
            lblRevenue.Text = Internals.PESO + Rev.ToString("0,0.00");
        }

        private void RefreshExpenses()
        {
            lblExpenses.Text = Internals.PESO + Expenses.ToString("0,0.00");
        }

        private void RefreshProfit()
        {
            lblProfit.Text = Internals.PESO + Profit.ToString("0,0.00");
        }
    }
}
