using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling.LooselyCoupled
{
    /// <summary>
    /// this is a silly example and can be refactored a lot further, but for now, its fine for demonstrating decoupling (focussing on the Product Controller)
    /// </summary>
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
                return AddProduct(airtime);
            }
            catch
            {
                return false;
            }
        }

        private bool AddProduct(Product airtime)
        {
            airtime = Controller.GetProduct(airtime);

            BasketItems.Add(airtime.GetType().Name, airtime);

            return true;
        }

        public bool AddAccountPayment()
        {
            try
            {
                Product accPay = new AccountPayment();
                return AddProduct(accPay);
            }
            catch
            {
                return false;
            }
        }
    }
}
