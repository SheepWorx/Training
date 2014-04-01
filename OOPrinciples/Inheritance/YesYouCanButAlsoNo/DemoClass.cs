using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.YesYouCanButAlsoNo
{
    /// <summary>
    /// in C# you can inherit from multiple interfaces, but only one class at a time
    /// </summary>
    /// <devnotes>
    /// class Class1: AbstractClass1, AbstractClass2 will cause a compiler error
    /// </devnotes>
    class DemoClass: Interface1,Interface2, Interface3
    {

        #region Interface3 Members

        public void Method3()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Interface2 Members

        public void Method2()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Interface1 Members

        public void Method1()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

