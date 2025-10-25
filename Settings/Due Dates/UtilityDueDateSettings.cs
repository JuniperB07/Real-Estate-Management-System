using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NET8.WinForms;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Settings.Due_Dates
{
    public partial class UtilityDueDateSettings : Form
    {
        public UtilityDueDateSettings()
        {
            InitializeComponent();
        }

        private void UtilityDueDateSettings_Load(object sender, EventArgs e)
        {
            txtDueDateDay.Text = "";
            Forms.SetControlVisible(new Control[] { lblDueDateDay, txtDueDateDay }, false);

            cmbDueDateMode.Items.Clear();
            foreach (string ddm in EnumHelper<Configs.DueDateModes>.ToList())
                cmbDueDateMode.Items.Add(ddm.Replace('_', ' '));

            cmbDueDateMode.Text = Configs.DueDates.DueDatesConfig.DueDateMode_Utilities.ToString().Replace('_', ' ');
        }

        private void cmbDueDateMode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbDueDateMode.Text))
            {
                if (cmbDueDateMode.Text == Configs.DueDateModes.User_Defined.ToString().Replace('_', ' '))
                {
                    Forms.SetControlVisible(new Control[] { lblDueDateDay, txtDueDateDay }, false);
                    txtDueDateDay.Text = Configs.DueDates.DueDatesConfig.DueDate_Internet.ToString();
                }
            }
            else
                Forms.SetControlVisible(new Control[] { lblDueDateDay, txtDueDateDay }, false);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
