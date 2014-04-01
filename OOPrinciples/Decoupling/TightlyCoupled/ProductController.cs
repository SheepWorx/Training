using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling.TightlyCoupled
{
    /// <summary>
    /// product controller is tightly coupled to AccountPayment and Airtime
    /// </summary>
    public class ProductController
    {
        private const decimal TAX = 0.14m;

        public AccountPayment GetAccountPayment()
        {
            AccountPayment accPay = new AccountPayment();
            accPay.Price = accPay.Price + (accPay.Price * TAX);

            return accPay;
        }

        public Airtime GetAirtime()
        {
            Airtime airtime = new Airtime();
            airtime.Price = airtime.Price + (airtime.Price * TAX);

            return airtime;
        }
    }
}
