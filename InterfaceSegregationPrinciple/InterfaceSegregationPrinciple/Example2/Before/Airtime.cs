using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example2.Before
{
    /// <summary>
    /// lets say that you can two classes.. fixed and variable airtime. both use getprice so nothing wrong here.
    /// 
    /// what happens when we introduce something that only one of the classes can use...? this is also a violation of the LSP.
    /// 
    /// why should VariableAirtime need to define CheckStock when it will never use it?
    /// </summary>
    public abstract class Airtime
    {
        public abstract decimal GetPrice();
        public abstract bool CheckStock();
    }
}
