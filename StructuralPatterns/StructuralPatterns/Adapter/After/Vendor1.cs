using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.After
{
    /// <summary>
    /// this class is part of our original solution and thus adheres to the IVendor interface
    /// </summary>
    public class Vendor1: IVendor
    {
        #region IVendor Members

        public string QueryItem(string identifier)
        {
            //make webservice call to vendor and return xml response
            return string.Empty;
        }

        public BasketItem RequestItem(BasketItem item)
        {
            //make webservice call to vendor, update item and return
            return item;
        }

        public bool CancelItem(BasketItem item)
        {
            //make webservice call to vendor and return response
            return true;
        }

        public bool ConfirmItem(BasketItem item)
        {
            //make webservice call to vendor and return response
            return true;
        }

        #endregion
    }
}
