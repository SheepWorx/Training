using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._2._OCP_by_Inheritance.BertrandMeyer.After
{
    /// <summary>
    /// i could successfully extend product without making any changes, appart from the virtual keyword. 
    /// 
    /// any classes still using product are unaffected and productextened can now be consumed by any new classes
    /// </summary>
    public class AirtimeProduct: Product
    {
        public string OrderNumber { get; set; }

        public override string GetProductDescription()
        {
            return string.Format("Airtime: {0} part of order {1}", Name, OrderNumber);
        }
    }
}
