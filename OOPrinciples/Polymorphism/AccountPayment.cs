using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class AccountPayment: Product
    {
        public override void DisplayProduct()
        {
            Console.WriteLine("Account Payment: Price = {0}", Price);
        }

        public void IOnlyHaveThis()
        {
        }

        public override int Price
        {
            get
            {
                return 5;
            }
        }
    }
}
