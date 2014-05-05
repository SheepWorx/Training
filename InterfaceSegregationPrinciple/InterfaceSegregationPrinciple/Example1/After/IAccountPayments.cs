using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Example1.After
{
    /// <summary>
    /// now the classes only need to inherit what they're going to use
    /// </summary>
    interface IAccountPayments
    {

        bool ValidateAccountNumber(IProduct product);
    }
}
