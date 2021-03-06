﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AbstractFactory.After.Authentication;
using FactoryPattern.AbstractFactory.After.Payment;
using FactoryPattern.AbstractFactory.After.Receipt;

namespace FactoryPattern.AbstractFactory.After.Factories
{
    public interface IChannelFactory
    {
        IUser GetTypeOfUser();
        IMethodOfPayment GetMethodOfPayment();
        IReceipt GetTypeOfReceipt();
    }
}
