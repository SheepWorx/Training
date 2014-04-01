using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling.TightlyCoupled
{
    public class AccountPayment
    {
        public decimal Price { get; set; }

        public AccountPayment()
        {
            Price = 5;
        }
    }
}
