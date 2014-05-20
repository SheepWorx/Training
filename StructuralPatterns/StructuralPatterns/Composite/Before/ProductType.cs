using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.Before
{
    public class ProductType
    {
        public IList<Vendor> Vendors { get; set; }

        public string Name { get; set; }

        public ProductType(string ProductTypeName)
        {
            Name = ProductTypeName;
            Vendors = new List<Vendor>();
        }

        public string DisplayMe()
        {
            return Name;
        }


    }
}
