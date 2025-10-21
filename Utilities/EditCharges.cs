using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Utilities
{
    public partial class EditCharges : Form
    {
        UtilityChargeMetadata OriginalUCM;
        UtilityChargeMetadata UpdatedUCM;
        Dialogs.MSGBox_OK MBOK;

        public EditCharges()
        {
            InitializeComponent();
            MBOK = new Dialogs.MSGBox_OK();
        }

        private void EditCharges_Load(object sender, EventArgs e)
        {
            OriginalUCM = UHelper.UtilityChargeInfo.Value;

            ResetForm();
            FillForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateUtilityChargeInformation();
        }

        private void txtWaterCharge_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtWaterCharge.Text))
            {
                if (double.TryParse(txtWaterCharge.Text, out _))
                {
                    UpdatedUCM.WaterCharge = Convert.ToDouble(txtWaterCharge.Text);
                    return;
                }
            }

            UpdatedUCM.WaterCharge = -1;
        }

        private void txtElectricityCharge_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtElectricityCharge.Text))
            {
                if (double.TryParse(txtElectricityCharge.Text, out _))
                {
                    UpdatedUCM.ElectricityCharge = Convert.ToDouble(txtElectricityCharge.Text);
                    return;
                }
            }

            UpdatedUCM.ElectricityCharge = -1;
        }
    }
}
