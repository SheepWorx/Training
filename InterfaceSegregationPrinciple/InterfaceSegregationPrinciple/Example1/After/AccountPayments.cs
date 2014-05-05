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
    class AccountPayments: IProduct, IAccountPayments
    {
        public bool SaveProduct(IProduct product)
        {
            //do something
            return true;
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
    }
}
