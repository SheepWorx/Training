using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._3._OCP_by_Extension.After
{
    /// <summary>
    /// the only change we needed to make here was to make the GetProductDescription method virtual
    /// 
    /// thus, we can inherit of this class and override it
    /// </summary>
    public class Product
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public string GetProductDescription()
        {
            return string.Format("Product: {0} costs {1}", Name, Amount);
        }
    }
}
