using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.After
{
    /// <summary>
    /// this is our contract for the both parenth and product (the final child). the dif
    /// </summary>
    public abstract class RetailItem
    {
        protected string Name { get; set; }

        public RetailItem(string retailItemName)
        {
            Name = retailItemName;
        }

        public abstract void Add(RetailItem child);
        public abstract void Remove(RetailItem child);
        public abstract void Display(int depth, StringBuilder sb);
        public string Display()
        {
            return Name;
        }
    }
}
