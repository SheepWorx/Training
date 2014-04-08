using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.Before
{
    /// <summary>
    /// this class violates the SRP. More so, this functions or utils class is actually an ANTI-PATTERN in the OO world.
    /// 
    /// The orig idea is that functions that have no place to go, all get put in one class, but there is no such thing as no place for code. If code truly has no place or function, should it then even exist?
    /// 
    /// This class will now become a potential monster.. just growing and growing and growing. Util classes also tend to become stable classes and since this class (should be stateless) has no interface, 
    /// it makes testing code that depends on this class, in isolation, difficult.
    /// </summary>
    public class ProductFunctions
    {
        private const decimal VAT = 0.14m;

        public string GetProductDescription(Product product)
        {
            return string.Format("Product: {0} - {1}", product.Name, product.Type);
        }

        public decimal CalculateVat(Product product)
        {
            return product.Amount * VAT;
        }
    }
}
