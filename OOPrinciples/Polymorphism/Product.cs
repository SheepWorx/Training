using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Product
    {
        public virtual void DisplayProduct()
        {
            Console.WriteLine("Base Product: Price = {0}", Price);
        }

        public virtual int Price
        {
            get
            {
                return 0;
            }
        }

        public virtual int PriceToExport
        {
            get
            {
                return 1;
            }
        }
    }
}
