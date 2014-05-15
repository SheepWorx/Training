using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    public class AccountPaymentBasketFactory: BasketFactory
    {
        public override IProduct CreateProduct(string referenceNumber)
        {
            return new AccountPayment();
        }
    }
}
