using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._1._BasicSRP._1._2_After
{
    /// <summary>
    /// product now only has one reason to change.. so job done. 
    /// 
    /// description formatting from a code cohesion point of view is now less and this might be overkill....
    /// </summary>
    public abstract class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }
}
