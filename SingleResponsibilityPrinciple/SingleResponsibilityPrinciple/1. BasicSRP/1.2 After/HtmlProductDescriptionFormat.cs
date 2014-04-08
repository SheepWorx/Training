using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._1._BasicSRP._1._2_After
{
    public class HtmlProductDescriptionFormat: IProductDescriptionFormat
    {

        #region IProductDescriptionFormat Members

        public string GetProductDescription(string productName, string productType)
        {
            return string.Format("<b>Product:</b> {0} - {1}", productName, productType);
        }

        #endregion
    }
}
