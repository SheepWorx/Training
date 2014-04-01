using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling.LooselyCoupled
{
    public class Basket
    {
        public Dictionary<string, object> BasketItems { get; private set; }
        public IProductController Controller { get; set; }

        public Basket()
        {
            BasketItems = new Dictionary<string,object>();
            Controller = new ProductController();
        }

        public bool AddAirtime()
        {
            try
            {
                Product airtime = new Airtime();
                airtime = Controller.GetProduct(airtime);

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
                Product accPay = new AccountPayment();
                accPay = Controller.GetProduct(accPay);

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
