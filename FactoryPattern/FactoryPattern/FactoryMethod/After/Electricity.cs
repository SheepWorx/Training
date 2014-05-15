using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    public class Electricity : IProduct
    {
        public string Display()
        {
            return GetType().Name;
        }

        public bool ValidateMe()
        {
            return true;
        }

        public bool LookupMeterNumber(string referenceNumber)
        {
            return true;
        }
    }
}
