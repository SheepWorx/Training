using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory.After
{
    public class ProductFactory
    {
        public static IProduct Create(string productType)
        {
            IProduct selectedProductType = null;

            switch (productType)
            {
                case "AccountPayment":
                    selectedProductType = new AccountPayment();
                    break;
                case "Electricity":
                    selectedProductType = new Electricity();
                    break;
                case "Airtime":
                    selectedProductType = new Airtime();
                    break;
            }

            return selectedProductType;
        }
    }
}
