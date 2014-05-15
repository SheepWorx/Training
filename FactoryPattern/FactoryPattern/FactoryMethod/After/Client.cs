using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    /// <summary>
    /// nice. now we've fully delegated the creation functionality to their respective factories. Also, should one of the products's
    /// requirements change, creation wise, changes will only be isolated to that product and it's factory.
    /// </summary>
    public class Client
    {
        public IBasket BuyAccountPayment(decimal price, string referenceNumber)
        {
            BasketFactory factory = new AccountPaymentBasketFactory();
            return factory.GetBasket(price, referenceNumber);
        }

        public IBasket BuyElectricity(decimal price, string referenceNumber)
        {
            BasketFactory factory = new ElectricityBasketFactory();
            return factory.GetBasket(price, referenceNumber);
        }

        public IBasket BuyAirtime(decimal price, string referenceNumber)
        {
            BasketFactory factory = new AirtimeBasketFactory();
            return factory.GetBasket(price, referenceNumber);
        }
    }
}
