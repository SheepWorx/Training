using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.After.Authentication
{
    public class Cashier: IUser
    {
        public bool Authenticate() { return true; }
    }
}
