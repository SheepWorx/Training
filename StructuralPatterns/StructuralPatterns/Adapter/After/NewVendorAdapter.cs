using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.After
{
    /// <summary>
    /// our adapter class now adheres to both the newvendor class and the IVendor interface. Our system can now use this class to
    /// interact with the NewVendor class.
    /// </summary>
    public class NewVendorAdapter: NewVendor, IVendor
    {
        #region IVendor Members

        public string QueryItem(string identifier)
        {
            return base.LookupMeterNumber(identifier);
        }

        public BasketItem RequestItem(BasketItem item)
        {
            base.RequestItem(item.ReferenceNumber, item.Amount);

            return item;
        }

        public bool CancelItem(BasketItem item)
        {
            try
            {
                base.CancelItem(item.ReferenceNumber);
                return true;
            }
            catch (Exception ex)
            {
                //log exception
                return false;
            }
        }

        public bool ConfirmItem(BasketItem item)
        {
            try
            {
                base.ConfirmItem(item.ReferenceNumber, item.Amount);
                return true;
            }
            catch (Exception ex)
            {
                //log exception
                return false;
            }
        }

        #endregion
    }
}
