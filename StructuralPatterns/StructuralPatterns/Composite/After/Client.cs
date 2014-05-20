using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.After
{
    /// <summary>
    /// add comments here
    /// </summary>
    public class Client
    {
        public StringBuilder DisplayHierarchy()
        {
            Parent rootItem = BuildHierarchy();

            StringBuilder sb = new StringBuilder();
            rootItem.Display(0, sb); 

            return sb;
        }

        private Parent BuildHierarchy()
        {

            //build hierarchy
            Parent root = new Parent("Root");
            Parent accpay = new Parent("Account Payments");
            Parent electricity = new Parent("Electricity");

            Parent easypayAccPay = new Parent("EasyPay");
            Parent easypayElectricity = new Parent("EasyPay");
            Parent payat = new Parent("Pay@");
            Parent eskom = new Parent("Eskom");

            Product easypayElectricityProduct = new Product("Product Code: 123456");
            Product easypayAccountPaymentProduct = new Product("Product Code: 333778");
            Product payatAccountPaymentProduct = new Product("Product Code: 896123");
            Product eskomElectricityProduct = new Product("Product Code: 443123");

            easypayAccPay.Add(easypayAccountPaymentProduct);
            easypayElectricity.Add(easypayElectricityProduct);
            payat.Add(payatAccountPaymentProduct);
            eskom.Add(eskomElectricityProduct);

            accpay.Add(easypayAccPay);
            accpay.Add(payat);
            electricity.Add(easypayElectricity);
            electricity.Add(eskom);

            root.Add(accpay);
            root.Add(electricity);

            return root;
        }
    }
}
