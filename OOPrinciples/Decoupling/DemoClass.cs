using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling
{
    public class DemoClass
    {
        [STAThread]
        public static void Main()
        {
            DemoTightlyCoupled();
            DemoLooselyCoupled();
            Console.ReadKey();
        }

        private static void DemoLooselyCoupled()
        {
            LooselyCoupled.Basket basket = new LooselyCoupled.Basket();
            basket.AddAccountPayment();
            basket.AddAirtime();

            Console.WriteLine("Loosely Coupled: Number of Items: {0}", basket.BasketItems.Count());
        }

        private static void DemoTightlyCoupled()
        {
            TightlyCoupled.Basket basket = new TightlyCoupled.Basket();
            basket.AddAccountPayment();
            basket.AddAirtime();

            Console.WriteLine("TightlyCoupled Coupled: Number of Items: {0}", basket.BasketItems.Count());
        }
    }
}
