using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._1._BasicSRP._1._2_After
{
    /// <summary>
    /// seperate formatter introduced to handle possible various formats of product description 
    /// </summary>
    interface IProductDescriptionFormat
    {
        string GetProductDescription(string productName, string productType);
    }
}
