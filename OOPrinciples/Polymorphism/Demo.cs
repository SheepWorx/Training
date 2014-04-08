using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// a simple demo to show the power of polymorphism. just because ure casting a child class to its parent, does not mean that it becomes the parent
    /// you'll simply only have access to the parent's properties, vars and methods.
    /// 
    /// Liskov's Substitution Principle also comes into play here (to be discussed at a later stage)
    /// </summary>
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
