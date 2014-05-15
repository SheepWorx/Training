using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AbstractFactory.After.Payment;

namespace FactoryPattern.AbstractFactory.After.Payment
{
    public class Wallet : IMethodOfPayment
    {
        public void PurchaseProduct() { }
    }
}
