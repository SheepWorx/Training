using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple._1._OCP_by_Composition.Before
{
    /// <summary>
    /// if we want this class to use any other logger other than DBLogger, then this class violates the OCP
    /// I need to change this class to introduce a new logger, which means its not closed to changes
    /// This class is also not open for extension since I need to change it should I want to add a new type of logger
    /// </summary>
    public class SomeService
    {
        private DBLogger Logger { get; set; }

        public SomeService()
        {
            Logger = new DBLogger();
        }

        public void DoWork()
        {
            //log action
            Logger.Debug("Work done");
        }
    }
}
