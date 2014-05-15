using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AbstractFactory.After.Authentication;
using FactoryPattern.AbstractFactory.After.Payment;
using FactoryPattern.AbstractFactory.After.Receipt;

namespace FactoryPattern.AbstractFactory.After.Factories
{
    public class WebChannel: IChannelFactory
    {
        public IUser GetTypeOfUser()
        {
            return new WebUser();
        }

        public virtual IMethodOfPayment GetMethodOfPayment()
        {
            return new Card();
        }

        public virtual IReceipt GetTypeOfReceipt()
        {
            return new EmailReceipt();
        }
    }
}
