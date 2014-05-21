using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite.After
{
    /// <summary>
    /// one of the many advantages of the composite pattern that i love is that you can now swap parents around, which you couldnt before.
    /// 
    /// for any infinate number of parents, there will always be one leaf for a single path... which is a much simpler approach than what we used in the before code sample.
    /// 
    /// also demonstrated here is that the actual the logic to handle display of the object has been delegated to the pattern. now, this is not part of the pattern but it 
    /// does demonstrate the power of it. That you can easily implement this because the parents can be interrogated recursively.
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
