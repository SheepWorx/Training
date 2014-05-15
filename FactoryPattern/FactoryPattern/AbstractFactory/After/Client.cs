using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AbstractFactory.After.Authentication;
using FactoryPattern.AbstractFactory.After.Factories;
using FactoryPattern.AbstractFactory.After.Payment;
using FactoryPattern.AbstractFactory.After.Receipt;

namespace FactoryPattern.AbstractFactory.After
{

/// <summary>
/// sweet. as you can see the creation of our code has now been shifted and we can create various "strategies" without having to change any existing implemenations
/// for an example of that, see the WapChannel class. There we use the webchannel but specified that we want to use wallet for method of payment and sms for our
/// receipt delivery
/// 
/// this pattern makes creation of objects, especially when a lot of choice is involved, very flexible.
/// </summary>
    public class Client
    {
        private IChannelFactory ChannelFactory { get; set; }

        public Client(IChannelFactory channel)
        {
            ChannelFactory = channel;
        }

        public void MakePurchase()
        {
            IUser userType = ChannelFactory.GetTypeOfUser();
            IMethodOfPayment methodOfPayment = ChannelFactory.GetMethodOfPayment();
            IReceipt typeOfReceipt = ChannelFactory.GetTypeOfReceipt();

            userType.Authenticate();
            methodOfPayment.PurchaseProduct();
            typeOfReceipt.PrintReceipt();
        }
    }

    public class Demo
    {
        public Demo()
        {
            IChannelFactory factory = new WebChannel();
            Client client = new Client(factory);
            client.MakePurchase();
        }
    }
}
