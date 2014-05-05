using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example2.Before
{
    public class FixedAirtime: Airtime
    {
        public override decimal GetPrice()
        {
            //do something
            return 0;
        }

        public override bool CheckStock()
        {
            //do something
            return true;
        }
    }
}
