using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example1.Before
{
    /// <summary>
    /// this is a very stupid example, but i think it proves the point. there is obviously no reason for all of these methods to all be here
    /// 
    /// some of them apply specifically to Airtime and some apply to account payments. The rest belong to products in general.
    /// </summary>
    interface IProductFeatures
    {
        bool SaveProduct(IProduct product);

        IList<IProduct> LoadLocalPriceListing();

        IProduct GetProductFromDB(string productCode);

        bool ValidateProduct(IProduct product);

        bool ValidateAccountNumber(IProduct product);

        decimal CalculateTax (IProduct product);

        void SaveStockOrder(IProduct product);

    }
}
