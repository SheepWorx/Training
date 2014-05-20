using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.After
{
    public class Product: RetailItem
    {
        public string Name { get; set; }

        public Product(string productName) : base(productName) { }
        
        public override void Add(RetailItem child)
        {
            throw new NotImplementedException("Cannot add a child on this level");
        }

        public override void Remove(RetailItem child)
        {
            throw new NotImplementedException("Cannot remove a child on this level");
        }

        public override void Display(int depth, StringBuilder sb)
        {
            sb.Append(new string('-',depth));
            sb.AppendLine(Display());
        }
    }
}
