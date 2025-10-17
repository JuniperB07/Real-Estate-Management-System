using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Tenants.Activity
{
    internal static class ActivityHelper
    {
        internal static bool AreClosed(IEnumerable<Form> ChildForms, out List<Form> Visibles)
        {
            bool AC = true;
            List<Form> V = new List<Form>();

            foreach(Form CF in ChildForms)
            {
                if(CF.Visible)
                {
                    AC = false;
                    V.Add(CF);
                }
            }

            Visibles = V;
            return AC;
        }
    }
}
