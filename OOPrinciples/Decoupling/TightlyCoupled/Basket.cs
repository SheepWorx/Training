using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling.TightlyCoupled
{
    /// <summary>
    /// basket is tightly coupled to the Product controller.. and thus untestable
    /// </summary>
    public class Basket
    {
        public Dictionary<string, object> BasketItems { get; private set; }

        public Basket()
        {
            BasketItems = new Dictionary<string,object>();
        }

        public bool AddAirtime()
        {
            try
            {
                ProductController controller = new ProductController();
                Airtime airtime = controller.GetAirtime();

                BasketItems.Add(airtime.GetType().Name, airtime);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddAccountPayment()
        {
            try
            {
                ProductController controller = new ProductController();
                AccountPayment accPay = controller.GetAccountPayment();

                BasketItems.Add(accPay.GetType().Name, accPay);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
