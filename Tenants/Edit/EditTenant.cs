using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Tenants
{
    public partial class EditTenant : Form
    {
        public EditTenant()
        {
            InitializeComponent();
        }

        private void EditTenant_Load(object sender, EventArgs e)
        {
            this.Text = EditHelper.FormTitle_EditTenant;

            pcbIDPhoto.Image = Properties.Resources.REMS_TENANTS_DEFAULT_ID;
        }

        private void EditTenant_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
