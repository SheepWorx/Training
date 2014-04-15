using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._1._OCP_by_Interfaces__Composition_.After
{
    public interface ILogger
    {
        void Debug(string message);
        void Warning(string message);
        void Error(string message);
        void Info(string message);
    }
}
