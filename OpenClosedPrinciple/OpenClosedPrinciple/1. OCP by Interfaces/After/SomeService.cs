using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._1._OCP_by_Interfaces__Composition_.After
{
    /// <summary>
    /// Now we have extended this class to allow any type of logger while ensuring that the code doesn't need to change should we want to use a different logger
    /// </summary>
    public class SomeService
    {
        private ILogger Logger { get; set; }

        public SomeService()
        {
            Logger = new DBLogger();
        }

        public SomeService(ILogger someLogger)
        {
            Logger = someLogger;
        }

        public void DoWork()
        {
            //log action
            Logger.Debug("Work done");
        }
    }
}
