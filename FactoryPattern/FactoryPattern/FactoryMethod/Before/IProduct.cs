using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.Before
{
    public interface IProduct
    {
        string Display();
        bool ValidateMe();
    }
}
