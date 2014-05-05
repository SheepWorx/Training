using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example2.Before
{
    public class VariableAirtime: Airtime
    {
        public override decimal GetPrice()
        {
            //do something
            return 0;
        }

        public override bool CheckStock()
        {
            // does not apply here
            throw new NotImplementedException();
        }
    }
}
