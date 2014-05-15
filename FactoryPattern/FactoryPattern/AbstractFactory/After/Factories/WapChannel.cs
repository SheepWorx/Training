using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AbstractFactory.After.Payment;
using FactoryPattern.AbstractFactory.After.Receipt;

namespace FactoryPattern.AbstractFactory.After.Factories
{
    public class WapChannel: WebChannel
    {
        public override IMethodOfPayment GetMethodOfPayment()
        {
            return new Wallet();
        }

        public override IReceipt GetTypeOfReceipt()
        {
            return new SmsReceipt();
        }
    }
}
