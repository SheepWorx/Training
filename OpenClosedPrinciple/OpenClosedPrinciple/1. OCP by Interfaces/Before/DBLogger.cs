using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._1._OCP_by_Composition.Before
{
    public class DBLogger
    {
        public void Debug(string message) { }
        public void Warning(string message) { }
        public void Error(string message) { }
        public void Info(string message) { }
    }
}
