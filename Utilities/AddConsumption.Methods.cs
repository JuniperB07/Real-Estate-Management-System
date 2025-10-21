using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Utilities
{
    partial class AddConsumption
    {
        private void ResetForm()
        {
            Forms.ClearControlText(new TextBox[] { txtElectricity, txtWater });
            cmbMonth.Items.Clear();
            nudYear.Maximum = DateTime.Now.Year;
            nudYear.Minimum = 2000;
            nudYear.Value = DateTime.Now.Year;
            NewCM.Year = Convert.ToInt32(nudYear.Value);
        }

        private void FillMonthsCMB()
        {
            if(nudYear.Value == DateTime.Now.Year)
            {
                List<string> months = EnumHelper<MonthsList>.ToList();

                cmbMonth.Items.Clear();

                for (int i = 0; i < DateTime.Now.Month; i++)
                    cmbMonth.Items.Add(months[i]);
            }
            else
                Forms.FillComboBox(cmbMonth, EnumHelper<MonthsList>.ToList());
        }

        private void Save()
        {
            //---VALIDATE INPUTS---
            if (!NewCM.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please fill all fields and make sure all inputs are valid.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //---CHECK IF DATA ALREADY EXISTS---
            new SelectCommand<tbutilities_consumption>()
                .SelectAll.From
                .StartWhere
                    .Where(tbutilities_consumption.BuildingID, SQLOperator.Equal, UHelper.BuildingID.ToString())
                    .And()
                    .StartGroup(tbutilities_consumption.Year, SQLOperator.Equal, NewCM.Year.ToString())
                        .And(tbutilities_consumption.Month, SQLOperator.Equal, "'" + NewCM.Month + "'")
                    .EndGroup
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
            {
                Internals.DBC.CloseReader();

                MBOK = new Dialogs.MSGBox_OK(this.Text, "A consumption data for this year and month already exists.\nIf you want to edit this consumption data, please contact administrator.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }
            Internals.DBC.CloseReader();

            //---SAVE CONSUMPTION DATA---
            new InsertIntoCommand<tbutilities_consumption>()
                .Column(new tbutilities_consumption[]
                {
                    tbutilities_consumption.BuildingID,
                    tbutilities_consumption.Year,
                    tbutilities_consumption.Month,
                    tbutilities_consumption.WaterConsumption,
                    tbutilities_consumption.ElectricityConsumption
                })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(UHelper.BuildingID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(NewCM.Year.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(NewCM.Month, DataTypes.NonNumeric),
                    new ValuesMetadata(NewCM.WaterConsumption.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(NewCM.ElectricityConsumption.ToString(), DataTypes.Numeric)
                })
                .ExecuteNonQuery(Internals.DBC);

            MBOK = new Dialogs.MSGBox_OK(this.Text, "New consumption information saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            Close();
        }
    }
}
