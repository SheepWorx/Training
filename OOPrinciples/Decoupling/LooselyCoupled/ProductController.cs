using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling.LooselyCoupled
{
    public class ProductController : IProductController
    {
        public Product Product { get; set; }

        private const decimal TAX = 0.14m;

        public Product GetProduct(Product product)
        {
            product.Price = product.Price + (product.Price * TAX);

            return product;
        }
    }
}
