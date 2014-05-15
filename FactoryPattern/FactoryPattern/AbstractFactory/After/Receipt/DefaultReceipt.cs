using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AbstractFactory.After.Receipt;

namespace FactoryPattern.AbstractFactory.After.Receipt
{
    public class DefaultReceipt: IReceipt
    {
        public void PrintReceipt() { }
    }
}
