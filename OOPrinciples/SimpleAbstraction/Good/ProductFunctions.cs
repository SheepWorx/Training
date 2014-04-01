using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstraction.Good
{
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
