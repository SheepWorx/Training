using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.Before
{
    /// <summary>
    /// here we have a typical hierarchical structure. In this sample, we have product types that have vendors as childern, who in turn have products as children
    /// 
    /// ok, so a couple of issues with this solution
    /// 
    /// 1) very little reuse in this solution
    /// 2) recursion would be best suited here to interrogate the tree from the top down,for ex. something which is not currently possible
    /// 3) types are tightly coupled so if you want to swap parents out, its very difficult
    /// 
    /// 
    /// The composite pattern was designed for scenarios such as this. Let's see how this pattern would address this scenario
    /// </summary>
    public class Client
    {
        public StringBuilder DisplayHierarchy()
        {
            IList<ProductType> list = BuildHierarchy();

            StringBuilder sb = PrintAll(list);

            return sb;
        }

        private StringBuilder PrintAll(IList<ProductType> list)
        {
            StringBuilder displayText = new StringBuilder();

            foreach (ProductType productType in list)
            {
                displayText.AppendLine(productType.DisplayMe());

                foreach(Vendor vendor in productType.Vendors)
                {
                    displayText.AppendLine(string.Format("-{0}",vendor.DisplayMe()));

                    foreach (Product product in vendor.Products)
                    {
                        displayText.AppendLine(string.Format("--{0}", product.DisplayMe()));
                    }
                }
            }

            return displayText;
        }

        private IList<ProductType> BuildHierarchy()
        {

            //build hierarchy
            ProductType accpay = new ProductType("Account Payments");
            ProductType electricity = new ProductType("Electricity");

            Vendor easypayAccPay = new Vendor("EasyPay");
            Vendor easypayElectricity = new Vendor("EasyPay");
            Vendor payat = new Vendor("Pay@");
            Vendor eskom = new Vendor("Eskom");

            Product easypayElectricityProduct = new Product("Product Code: 123456");
            Product easypayAccountPaymentProduct = new Product("Product Code: 333778");
            Product payatAccountPaymentProduct = new Product("Product Code: 896123");
            Product eskomElectricityProduct = new Product("Product Code: 443123");


            easypayAccPay.Products.Add(easypayAccountPaymentProduct);
            easypayElectricity.Products.Add(easypayElectricityProduct);
            payat.Products.Add(payatAccountPaymentProduct);
            eskom.Products.Add(eskomElectricityProduct);

            accpay.Vendors.Add(easypayAccPay);
            accpay.Vendors.Add(payat);

            electricity.Vendors.Add(easypayElectricity);
            electricity.Vendors.Add(eskom);

            IList<ProductType> returnList = new List<ProductType>();
            returnList.Add(accpay);
            returnList.Add(electricity);

            return returnList;
        }
    }
}
