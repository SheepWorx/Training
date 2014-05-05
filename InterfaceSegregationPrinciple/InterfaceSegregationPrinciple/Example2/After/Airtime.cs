using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example2.After
{
    /// <summary>
    /// we removed the checkstock from this class and wrapped it in a interface... fixed..yay
    /// </summary>
    public abstract class Airtime
    {
        public abstract decimal GetPrice();
    }
}
