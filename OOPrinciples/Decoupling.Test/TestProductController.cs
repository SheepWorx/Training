using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decoupling.LooselyCoupled;

namespace Decoupling.Test
{
    public class TestProductController : IProductController
    {
        public Product GetProduct(Product product)
        {
            Product airtime = new Airtime();
            airtime.Price = 2;

            return airtime;
        }
    }
}
