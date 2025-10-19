using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NETStandard.Utility;
using REMS.Tenants;

namespace Real_Estate_Management_System.Tenants.New
{
    public partial class NewTenancy : Form
    {
        TenancyMetadata tenancyInfo;

        public NewTenancy()
        {
            InitializeComponent();
        }

        private void NewTenancy_Load(object sender, EventArgs e)
        {
            tenancyInfo = new TenancyMetadata();

            ResetForm();
            FillRentTypeCMB();
            FillBuildingCMB();
            FillStatusCMB();
        }

        private void cmbRentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(cmbRentType.Text))
            {
                
            }
        }
    }
}
