using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    public class AirtimeBasketFactory: BasketFactory
    {
        public override IProduct CreateProduct(string referenceNumber)
        {
            Airtime airtime = new Airtime();

            if (airtime.IsStockAvailable(referenceNumber))
                return airtime;
            else
                throw new Exception("No stock is available");
        }
    }
}
