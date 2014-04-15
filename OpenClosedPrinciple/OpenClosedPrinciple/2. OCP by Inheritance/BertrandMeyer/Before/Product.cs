using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._2._OCP_by_Inheritance.BertrandMeyer.Before
{
    /// <summary>
    /// lets say this this code is already in production and many classes use it.
    /// 
    /// you wan to extend this class and add additional functionality. you also want to change the product description
    /// 
    /// how can you do this safely?
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
