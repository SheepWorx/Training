using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Encapsulation.Good
{
    /// <summary>
    /// this is obviosly the simplest of examples. Encapsulation can go much further than this when it comes to setting access modifiers for classes.
    /// </summary>
    public class Product
    {
        /*
         * looks much better
         * now you can exert more control over who has access to those variables
         */

        //read-only properties
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Product(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
