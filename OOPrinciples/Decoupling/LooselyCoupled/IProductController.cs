using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling.LooselyCoupled
{
    public interface IProductController
    {
        Product GetProduct(Product product);
    }
}
