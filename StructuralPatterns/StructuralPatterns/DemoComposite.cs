using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    public class DemoComposite
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Composite.Before.Client client = new Before.Client();
            Composite.After.Client client1 = new After.Client();

            
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            Console.WriteLine("Before");
            Console.WriteLine(client.DisplayHierarchy());

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);

            Console.WriteLine("After");
            Console.WriteLine(client1.DisplayHierarchy());

            Console.ReadKey();
        }
    }

}
