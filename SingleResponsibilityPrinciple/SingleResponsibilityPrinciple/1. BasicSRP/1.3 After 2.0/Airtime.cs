using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._1._BasicSRP._1._3_After_2._0
{
    /// <summary>
    /// although this class violates the SRP, all changes to it are contextual to Airtime and thus it keeps a high level of code cohesion.
    /// </summary>
    public class Airtime: Product
    {
        public string CellNumber { get; set; }

        public override string GetProductDescription()
        {
            return string.Format("Product: {0} - {1}", Name, Type);
        }

        public override string GetHtmlProductDescription()
        {
            return string.Format("<b>Product:</b> {0} - {1}", Name, Type);
        }
    }
}
