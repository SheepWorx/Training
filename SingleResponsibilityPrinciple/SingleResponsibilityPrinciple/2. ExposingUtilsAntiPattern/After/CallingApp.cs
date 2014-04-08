using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.After.ProductUtilsAssembly;
using SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.After.ProductUtilsAssembly.CalculateVat;
using SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.After.ProductUtilsAssembly.FormatProduct;

namespace SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.After
{
    public class CallingApp
    {
        public void DoStuff()
        {
            Product localProd = new Product();

            localProd.Amount = 51.46M;
            localProd.Name = "Cell C Variable Airtime";
            localProd.Type = "Airtime";

            IDescriptionFormatter defaultDesc = new DefaultFormat();
            ICalculateVat saVat = new SaVat();

            Console.WriteLine(defaultDesc.GetProductDescription(localProd));
            Console.WriteLine(string.Format("VAT: {0}", saVat.CalculateVat(localProd)));
        }
    }
}
