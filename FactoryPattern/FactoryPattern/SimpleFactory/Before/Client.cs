using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory.Before
{
    /// <summary>
    /// The factory pattern is a creational pattern and solves the issue around the various rules involved in creating objects. See the example below.
    /// Here we have a class that needs to display various account types. You'll notice that each method does the same thing apart from the type of class instanciated.
    /// 
    /// What will happen when we need to add new types. We'll need to add a new method to instanciate that class and we'll need to change the displaystuff method
    /// 
    /// can we not rather have a class that takes care of the creation of the objects... and takes care of them in such a way, that this client class will not longer care
    /// about the type of class that gets instanciated?
    /// </summary>
    public class Client
    {
        private string DisplayAccountPayment()
        {
            AccountPayment accpay = new AccountPayment();
            return accpay.Display();
        }

        private string DisplayElectricity()
        {
            Electricity elec = new Electricity();
            return elec.Display();
        }

        private string DisplayAirtime()
        {
            Airtime airtime = new Airtime();
            return airtime.Display();
        }

        public void DisplayStuff(string productType)
        {
            if (productType == "AccountPayment")
            {
                Console.WriteLine(DisplayAccountPayment());
            }

            if (productType == "Electricity")
            {
                Console.WriteLine(DisplayElectricity());
            }

            if (productType == "Airtime")
            {
                Console.WriteLine(DisplayAirtime());
            }
        }
    }
}
