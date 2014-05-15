using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    public abstract class BasketFactory
    {
        public IBasket GetBasket(decimal price, string referenceNumber)
        {
            IBasket basket = new Basket();
            IProduct product = this.CreateProduct(referenceNumber);

            basket.Price = price;
            basket.ReferenceNumber = referenceNumber;

            if (basket.ValidateBasket())
                Console.WriteLine("About to purchase {0}", basket.DisplayBasket());
            else
                throw new Exception("Could not validate basket");

            return basket;
        }

        public abstract IProduct CreateProduct(string referenceNumber);
    }
}
