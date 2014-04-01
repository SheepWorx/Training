using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Encapsulation.Bad
{
    public class Product
    {
        /*
         * It's considered bad practice to make variables publicly accessable just for the sake of making them publicly accessable
         * How can this be solved using the levels of access: Public, Protected, Internal, Protected Internal and Private
         * 
         * General practice is that small classes or structs that just wrap data, should be immutable, ie unchangeable publicly.
         * Limiting access to variables to only the methods that should be able to change them, will reduce situations where you may
         *  end up with undesired state
        */
        public string Name;
        public string Type;
    }
}
