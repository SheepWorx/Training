using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example1.Before
{
    /// <summary>
    /// the airtime class now ends up with methods it will never use. best to seperate these out to something more specific
    /// </summary>
    class Airtime : IProduct, IProductFeatures
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

        public bool ValidateAccountNumber(IProduct product)
        {
            throw new NotImplementedException();
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
