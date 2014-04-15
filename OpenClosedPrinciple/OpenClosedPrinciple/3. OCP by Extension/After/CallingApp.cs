using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._3._OCP_by_Extension.After
{
    public class CallingApp
    {
        public void DoSomething()
        {
            Product p = new Product();
            p.Amount = 51.3m;
            p.Name = "bleProduct";

            Console.WriteLine("After Extension " + p.GetNewProductDescription());
        }
    }
}
