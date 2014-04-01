using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Airtime: Product
    {
        public override void DisplayProduct()
        {
            Console.WriteLine("Airtime: Price = {0}", Price);
        }

        public override int Price
        {
            get
            {
                return 7;
            }
        }

        public override int PriceToExport
        {
            get
            {
                return base.PriceToExport;
            }
        }
    }
}
