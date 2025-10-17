using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Tenants.New
{
    public partial class NewTenant : Form
    {
        public NewTenant()
        {
            InitializeComponent();
        }

        private void NewTenant_Load(object sender, EventArgs e)
        {
            pcbIDPhoto.Image = Properties.Resources.REMS_TENANTS_DEFAULT_ID;
        }
    }
}
