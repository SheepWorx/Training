using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory.After
{
    public class Electricity : IProduct
    {
        public string Display()
        {
            return GetType().Name;
        }
    }
}
