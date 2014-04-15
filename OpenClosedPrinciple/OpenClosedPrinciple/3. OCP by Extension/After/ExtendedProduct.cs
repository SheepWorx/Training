using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._3._OCP_by_Extension.After
{
    /// <summary>
    /// extension methods allow you to add new methods to existing types without having to create a new derived type. This was introduced with .Net 3.0
    /// 
    /// http://msdn.microsoft.com/en-us//library/bb383977.aspx
    /// </summary>
    public static class ExtendedProduct
    {
        public static string GetNewProductDescription(this Product p)
        {
            return string.Format("Extended Product: {0} is absolutely free", p.Name, p.Amount);
        }
    }
}
