using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.After.Payment
{
    public class Cash : IMethodOfPayment
    {
        public void PurchaseProduct() { }
    }
}
