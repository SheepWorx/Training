using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Encapsulation.BadIdea
{
    /// <summary>
    /// why is this a very BAD IDEA???
    /// </summary>
    /// <devnotes>
    /// ingore that type is a string for now. focus on the access level of the variables
    /// and the use of static.
    /// </devnotes>
    public static class Product
    {
        public static string Name { get; set; }
        public static string Type { get; set; }
    }
}
