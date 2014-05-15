using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    public class ElectricityBasketFactory: BasketFactory
    {
        public override IProduct CreateProduct(string referenceNumber)
        {
            Electricity elec = new Electricity();

            if (elec.LookupMeterNumber(referenceNumber))
                return elec;
            else
                throw new Exception("Could not find meter number");
        }
    }
}
