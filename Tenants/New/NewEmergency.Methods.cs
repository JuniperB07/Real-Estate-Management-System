using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;

namespace Real_Estate_Management_System.Tenants.New
{
    public partial class NewEmergency
    {
        private void ClearForm()
        {
            Forms.ClearControlText(new TextBox[]
            {
                txtAddress,
                txtEmergencyContact,
                txtPhone,
                txtRelationship
            });
        }
    }
}
