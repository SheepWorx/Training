using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._2._OCP_by_Inheritance.RobertCMartin.After
{
    /// <summary>
    /// Anything that used to reference product, will now need to change since this class has become abstract. That being said, this does make (according to me)
    /// more sense from a cohesion point of view.
    /// </summary>
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public abstract string GetProductDescription();
    }
}
