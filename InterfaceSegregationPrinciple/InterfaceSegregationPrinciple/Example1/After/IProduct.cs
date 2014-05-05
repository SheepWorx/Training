using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example1.After
{
    /// <summary>
    /// now the classes only need to inherit what they're going to use
    /// </summary>
    interface IProduct
    {
        bool SaveProduct(IProduct product);

        IProduct GetProductFromDB(string productCode);

        bool ValidateProduct(IProduct product);
    }
}
