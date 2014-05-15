using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.Before
{
    public class AccountPayment : IProduct
    {
        public string Display()
        {
            return GetType().Name;
        }

        public bool ValidateMe()
        {
            return true;
        }
    }
}
