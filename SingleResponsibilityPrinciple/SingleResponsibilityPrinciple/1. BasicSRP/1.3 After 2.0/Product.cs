using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._1._BasicSRP._1._3_After_2._0
{
    /// <summary>
    /// this now violates the SRP technically but it maintains it from a context point of view and allows for different versions based on product type
    /// 
    /// should we want to open this up for different types of (like below) its all fine and well, but we're moving close towards the 'Utils Class' antipattern.
    /// 
    /// with the SRP, changes like this need to be carefully evaluated in terms of where you want to go with it and what risks you're willing to accept.
    /// </summary>
    public abstract class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }

        public abstract string GetProductDescription();

        public abstract string GetHtmlProductDescription();
    }
}
