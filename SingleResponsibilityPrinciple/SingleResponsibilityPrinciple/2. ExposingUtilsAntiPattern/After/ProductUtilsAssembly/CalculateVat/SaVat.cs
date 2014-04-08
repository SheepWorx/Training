using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._2._ExposingUtilsAntiPattern.After.ProductUtilsAssembly.CalculateVat
{
    public class SaVat: ICalculateVat
    {
        private const decimal VAT = 0.14m;

        #region ICalculateVat Members

        public decimal CalculateVat(Product product)
        {
            return product.Amount * VAT;
        }

        #endregion
    }
}
