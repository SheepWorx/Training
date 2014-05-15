using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory.After.Authentication
{
    public interface IUser
    {
        bool Authenticate();
    }
}
