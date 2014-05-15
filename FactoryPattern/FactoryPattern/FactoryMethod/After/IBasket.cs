using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.After
{
    public interface IBasket
    {
        IProduct Product { get; set; }
        decimal Price { get; set; }
        string ReferenceNumber { get; set; }

        bool ValidateBasket();
        string DisplayBasket();
    }
}
