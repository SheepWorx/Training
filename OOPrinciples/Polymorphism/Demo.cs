using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Demo
    {
        [STAThread]
        public static void Main()
        {
            Execute();
        }

        private static void Execute()
        {
            AccountPayment accPay = new AccountPayment();
            DisplayPrice(accPay);

            Product prod = accPay as Product;
            DisplayPrice(prod);

            Airtime airtime = new Airtime();
            DisplayPrice(airtime);
        }

        private static void DisplayPrice(Product product)
        {
            product.DisplayProduct();

            Console.WriteLine("Type: {0}, Export Price = {1}", product.GetType().Name, product.PriceToExport);
        }
    }
}
