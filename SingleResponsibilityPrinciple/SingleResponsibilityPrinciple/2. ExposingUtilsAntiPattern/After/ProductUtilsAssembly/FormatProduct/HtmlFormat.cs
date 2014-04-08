using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.After.ProductUtilsAssembly.FormatProduct
{
    public class HtmlFormat: IDescriptionFormatter
    {
        #region IDescriptionFormatter Members

        public string GetProductDescription(Product product)
        {
            return string.Format("<b>Product:</b> {0} - {1}", product.Name, product.Type);
        }

        #endregion
    }
}
