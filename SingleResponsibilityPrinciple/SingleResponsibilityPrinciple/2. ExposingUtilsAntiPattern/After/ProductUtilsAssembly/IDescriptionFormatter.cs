using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.After.ProductUtilsAssembly
{
    interface IDescriptionFormatter
    {
        string GetProductDescription(Product product);
    }
}
