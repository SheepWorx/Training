using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.Before
{
    public class Vendor
    {
        public IList<Product> Products { get; set; }

        public string Name { get; set; }

        public Vendor(string VendorName)
        {
            Name = VendorName;
            Products = new List<Product>();
        }

        public string DisplayMe()
        {
            return Name;
        }
    }
}
