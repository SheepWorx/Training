using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod.Before
{
    public class Basket
    {
        public IProduct Product { get; set; }
        public decimal Price { get; set; }
        public string ReferenceNumber { get; set; }

        public bool ValidateBasket()
        {
            return Product.ValidateMe();
        }

        public string DisplayBasket()
        {
            return string.Format("R{0} of {1}", Price, Product.Display());
        }
    }
}
