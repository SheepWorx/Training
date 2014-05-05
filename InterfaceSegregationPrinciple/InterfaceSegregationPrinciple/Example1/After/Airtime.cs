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
    class Airtime : IProduct, IAirtime
    {
        public bool SaveProduct(IProduct product)
        {
            //do something
            return false;
        }

        public IList<IProduct> LoadLocalPriceListing()
        {
            //do something
            return null;
        }

        public IProduct GetProductFromDB(string productCode)
        {
            //do something
            return null;
        }

        public bool ValidateProduct(IProduct product)
        {
            //do something
            return false;
        }

        public decimal CalculateTax(IProduct product)
        {
            //do something
            return 0;
        }

        public void SaveStockOrder(IProduct product)
        {
            //do something
            
        }
    }
}
