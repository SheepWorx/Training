using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example1.Before
{
    /// <summary>
    /// the accountpayments class now ends up with methods it will never use. best to seperate these out to something more specific
    /// </summary>
    class AccountPayments: IProduct, IProductFeatures
    {
        public bool SaveProduct(IProduct product)
        {
            //do something
            return true;
        }

        public IList<IProduct> LoadLocalPriceListing()
        {
            throw new NotImplementedException();
        }

        public IProduct GetProductFromDB(string productCode)
        {
            //do something
            return null;
        }

        public bool ValidateProduct(IProduct product)
        {
            //do something
            return true;
        }

        public bool ValidateAccountNumber(IProduct product)
        {
            //do something
            return true;
        }

        public decimal CalculateTax(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void SaveStockOrder(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
