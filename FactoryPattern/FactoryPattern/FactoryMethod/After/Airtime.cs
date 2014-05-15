using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    public class Airtime : IProduct
    {
        public string Display()
        {
            return GetType().Name;
        }

        public bool ValidateMe()
        {
            return true;
        }

        public bool IsStockAvailable(string referenceNumber)
        {
            return true;
        }
    }
}
