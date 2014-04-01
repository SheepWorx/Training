using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling.TightlyCoupled
{
    public class Airtime
    {
        public decimal Price { get; set; }

        public Airtime()
        {
            Price = 10;
        }
    }
}
