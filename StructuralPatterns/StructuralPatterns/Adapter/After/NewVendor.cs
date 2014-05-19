using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.After
{
    /// <summary>
    /// this class was inherited from another system. traditionally it would be part of an assembly or project that we would reference. the class has been included the way it is, for convenience's sake
    /// 
    /// you'll notice that this class does not adhere to any interface and that its method signatures are completely different from our IVendor interface although the actions are similar
    /// 
    /// how do we adapt this class to adhere to our IVendor interface without changing any of the code in it?
    /// </summary>
    public class NewVendor
    {
        public string LookupMeterNumber(string meterNumber)
        {
            //lookup meter number
            return string.Empty;
        }

        public void CancelItem(string identifier)
        {
            try
            {
                //make call to vendor to cancel item
            }
            catch (Exception ex)
            {
                //log error msg
                throw new InvalidOperationException("A vendor error occured", ex);
            }
        }

        public void ConfirmItem(string identifier, decimal amount)
        {
            try
            {
                //make call to vendor to confirm item
            }
            catch (Exception ex)
            {
                //log error msg
                throw new InvalidOperationException("A vendor error occured", ex);
            }
        }

        public string RequestItem(string identifier, decimal amount)
        {
            try
            {
                //make call to vendor to request item and return xml response
                return string.Empty;
            }
            catch (Exception ex)
            {
                //log error msg
                throw new InvalidOperationException("A vendor error occured", ex);
            }
        }
    }
}
