using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.Before
{
    public class Product
    {
        public string Name { get; set; }

        public Product(string ProductName)
        {
            Name = ProductName;
        }

        public string DisplayMe()
        {
            return Name;
        }
    }
}
