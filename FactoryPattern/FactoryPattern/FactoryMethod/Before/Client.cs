using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.Before
{
    /// <summary>
    /// right... factory method. 
    /// 
    /// question: how do we delegate object creation where each different type might have a different actions involved when being created?
    /// 
    /// We can create factories that are bespoke to each product in this case and then wrap that with a factory to create our basket.
    /// </summary>
    public class Client
    {
        public Basket BuyAccountPayment(decimal price, string referenceNumber)
        {
            Basket basket = new Basket();

            basket.Product = new AccountPayment();
            basket.Price = price;
            basket.ReferenceNumber = referenceNumber;

            if (basket.ValidateBasket())
                Console.WriteLine("About to purchase {0}", basket.DisplayBasket());
            else
                throw new Exception("Could not validate basket");

            return basket;
        }

        public Basket BuyElectricity(decimal price, string referenceNumber)
        {
            Basket basket = new Basket();

            Electricity elec = new Electricity();
            if (elec.LookupMeterNumber(referenceNumber))
            {
                basket.Price = price;
                basket.ReferenceNumber = referenceNumber;
                basket.Product = elec;

                if (basket.ValidateBasket())
                    Console.WriteLine("About to purchase {0}", basket.DisplayBasket());
                else
                    throw new Exception("Could not validate basket");
            }
            else
                throw new Exception("Could not find meter number");

            return basket;
        }

        public Basket BuyAirtime(decimal price, string referenceNumber)
        {
            Basket basket = new Basket();

            Airtime airtime = new Airtime();
            if (airtime.IsStockAvailable(referenceNumber))
            {
                basket.Price = price;
                basket.ReferenceNumber = referenceNumber;
                basket.Product = airtime;

                if (basket.ValidateBasket())
                    Console.WriteLine("About to purchase {0}", basket.DisplayBasket());
                else
                    throw new Exception("Could not validate basket");
            }
            else
                throw new Exception("No stock is available");

            return basket;
        }
    }
}
