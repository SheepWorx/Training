using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Before = OpenClosedPrinciple._3._OCP_by_Extension.Before;
using After = OpenClosedPrinciple._3._OCP_by_Extension.After;

namespace OpenClosedPrinciple
{
    public class DemoExtension
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Before.CallingApp before = new Before.CallingApp();
            before.DoSomething();

            After.CallingApp after = new After.CallingApp();
            after.DoSomething();

            Console.ReadKey();
        }
    }
}
