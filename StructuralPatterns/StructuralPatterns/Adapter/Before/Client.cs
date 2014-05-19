using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.Before
{
    public class Client
    {
        /// <summary>
        /// ok, so here we have a nice piece of code. we want to fire off a call to an existing vendor in our system (that we coded) and we want to do a lookup for an electricity meter number.
        /// 
        /// nothing weird BUT now, a manager comes along and tells us we need to integrate the NewVendor class into our system. this class is currently part of another project and is actively in use.
        /// 
        /// How do we integrate this new class without changing both that class and our code below? How can we get that class to adhere to our IVendor interface.
        /// 
        /// Welcome to the adaptor pattern. The After folder has the solution to our problem
        /// </summary>
        /// <param name="meterNumber"></param>
        /// <returns></returns>
        public string LookupMeterNumber(string meterNumber)
        {

            IVendor callToVendor1 = new Vendor1();
            return callToVendor1.QueryItem(meterNumber);

        }
    }
}
