using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory.Before
{
    public class Electricity
    {
        public string Display()
        {
            return GetType().Name;
        }
    }
}
