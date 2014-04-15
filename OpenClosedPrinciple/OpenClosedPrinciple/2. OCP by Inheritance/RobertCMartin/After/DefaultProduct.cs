using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._2._OCP_by_Inheritance.RobertCMartin.After
{
    public class DefaultProduct : Product
    {
        public override string GetProductDescription()
        {
            return string.Format("Product: {0} costs {1}", Name, Amount);
        }
    }
}
