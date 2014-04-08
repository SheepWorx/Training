using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._1._BasicSRP._1._1_Before
{
    /// <summary>
    /// from a purist point of view, this class is violoating the SRP since it has 2 reasons to change:
    /// - when a new property needs to be added
    /// - when the description needs to change
    /// 
    /// contextually, this class makses sense and for the sake of cohesion, i would keep it like this.
    /// - the only time you would run into issues, is when you need different types of descriptions based on product type. Then ure likely to violate the LSP.
    /// </summary>
    public abstract class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }

        public string GetProductDescription()
        {
            return string.Format("Product: {0} - {1}", Name, Type);
        }
    }
}
