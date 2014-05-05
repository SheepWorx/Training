using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example2.After
{
    public class VariableAirtime: Airtime
    {
        public override decimal GetPrice()
        {
            //do something
            return 0;
        }
    }
}
