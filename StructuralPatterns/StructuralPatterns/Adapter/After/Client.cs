using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.After
{
    public class Client
    {
        /// <summary>
        /// We now have our NewVendorAdapter class that adheres to the adapter pattern. you'll notice that we can use the same code
        /// we would've for the Vendor1 class with the NewVendorAdapter class. We can now interface with the NewVendor class
        /// without having to change the class or having to change our code below (apart from calling the new class).
        /// 
        /// you can actually get around that using generics and Microsoft Unity. There you would just update the config file the 
        /// name of the new class and then that's all that you'd need to change.
        /// 
        /// very nifty!s
        /// </summary>
        /// <param name="meterNumber"></param>
        /// <returns></returns>
        public string LookupMeterNumber(string meterNumber)
        {

            IVendor callToVendor1 = new NewVendorAdapter();
            return callToVendor1.QueryItem(meterNumber);

        }
    }
}
