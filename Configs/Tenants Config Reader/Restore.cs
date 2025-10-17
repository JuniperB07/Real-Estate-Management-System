using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Real_Estate_Management_System.Configs.Tenants
{
    internal static partial class DefaultValues
    {
        internal static void RestoreDefaults()
        {
            Restore_Default_IDLocation();
            Restore_Default_Internet_Plan();
        }

        #region PRIVATES
        private static void Restore_Default_IDLocation()
        {
            doc = XDocument.Load(configPath);

            var target = doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Tenants:Default_IDLocation");

            if(target != null)
            {
                target.SetAttributeValue("value", DEFAULT_ID_LOCATION);
                doc.Save(configPath);
            }
        }
        private static void Restore_Default_Internet_Plan()
        {
            doc = XDocument.Load(configPath);

            var target = doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Tenants:Default_InternetPlan");

            if (target != null)
            {
                target.SetAttributeValue("value", DEFAULT_INTERNET_PLAN);
                doc.Save(configPath);
            }
        }
        #endregion
    }
}
