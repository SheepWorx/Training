using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Good
{
    /// <summary>
    /// this is actually an example of inheritance, polymorphism and abstraction 
    /// 
    /// you can inherit from either any old class (refering to Bertrand Meyer's approach to class extention, to be discussed when we do the Open/Close Principle), and interface class or an abstract class.
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
