using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstraction.Bad
{
    public class CallingApp
    {
        public void DoStuff()
        {
            Product localProd = new Product();

            localProd.Amount = 51.46M;
            localProd.Name = "Cell C Variable Airtime";
            localProd.Type = "Airtime";

            Console.WriteLine(localProd.GetProductDescription());
            Console.WriteLine(string.Format("VAT: {0}", localProd.CalculateVat()));
        }
    }
}
