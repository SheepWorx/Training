using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.Before
{
    /// <summary>
    /// ok.. well.. this works fine, right?
    /// 
    /// we have a few issues here. firstly, everything is tightly coupled.. which is never good. also, if i want to indroduce additional channels, this method will grow
    /// if I want to introduce different channels with slight variations, like a web channel that supports wallet payments and that smses receipts, I will have to repeat
    /// a bunch of code. also remember that whatever is calling this method, obviously knows what it wants since it's specifying the channel
    /// 
    /// should there be any reason for us to distinguish between the different types of channels here?
    /// </summary>
    public class Client
    {
        public void PurchaseProductOverChannel(string channel)
        {
            switch (channel)
            {
                case "mobile":
                    MobileUser mUser = new MobileUser();
                    Wallet mMethodOfPayment = new Wallet();
                    SmsReceipt mReceipt = new SmsReceipt();

                    mUser.Authenticate();
                    mMethodOfPayment.PurchaseProduct();
                    mReceipt.PrintReceipt();
                    break;

                case "pos":
                    Cashier pUser = new Cashier();
                    Cash pMethodOfPayment = new Cash();
                    DefaultReceipt pReceipt = new DefaultReceipt();

                    pUser.Authenticate();
                    pMethodOfPayment.PurchaseProduct();
                    pReceipt.PrintReceipt();
                    break;

                case "web":
                    WebUser wUser = new WebUser();
                    Card wMethodOfPayment = new Card();
                    EmailReceipt wReceipt = new EmailReceipt();

                    wUser.Authenticate();
                    wMethodOfPayment.PurchaseProduct();
                    wReceipt.PrintReceipt();
                    break;
            }
        }
    }

    public class Demo
    {
        public Demo()
        {
            Client client = new Client();
            client.PurchaseProductOverChannel("web");
        }
    }
}
