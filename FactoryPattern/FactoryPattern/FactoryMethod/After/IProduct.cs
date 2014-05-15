using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    public interface IProduct
    {
        string Display();
        bool ValidateMe();
    }
}
