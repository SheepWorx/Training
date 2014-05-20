using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.After
{
    public class Parent: RetailItem
    {
        private List<RetailItem> children = new List<RetailItem>();

        public Parent(string parentName) : base(parentName) { }

        public override void Add(RetailItem child)
        {
            children.Add(child);
        }

        public override void Remove(RetailItem child)
        {
            children.Remove(child);
        }

        public override void Display(int depth, StringBuilder sb)
        {
            sb.Append(new string('-',depth));
            sb.AppendLine(Display());

            depth += 1;

            foreach (RetailItem item in children)
            {
                item.Display(depth, sb);
            }

        }
    }
}
