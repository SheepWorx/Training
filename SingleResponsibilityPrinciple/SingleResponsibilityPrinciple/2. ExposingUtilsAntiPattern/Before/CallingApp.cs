using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.Before
{
    public class CallingApp
    {
        public void DoStuff()
        {
            Product localProd = new Product();

            localProd.Amount = 51.46M;
            localProd.Name = "Cell C Variable Airtime";
            localProd.Type = "Airtime";

            ProductFunctions func = new ProductFunctions();

            Console.WriteLine(func.GetProductDescription(localProd));
            Console.WriteLine(string.Format("VAT: {0}", func.CalculateVat(localProd)));
        }
    }
}
