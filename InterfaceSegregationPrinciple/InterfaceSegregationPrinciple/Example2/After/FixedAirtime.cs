using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example2.After
{
    public class FixedAirtime: Airtime, IStockItem
    {
        public override decimal GetPrice()
        {
            //do something
            return 0;
        }

        public bool CheckStock()
        {
            //do something
            return true;
        }
    }
}
