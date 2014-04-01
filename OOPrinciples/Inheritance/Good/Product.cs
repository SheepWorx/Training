using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Good
{
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
