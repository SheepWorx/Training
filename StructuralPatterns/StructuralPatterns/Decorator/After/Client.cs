using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.After
{
    public class Client
    {
        /// <summary>
        /// as you can see, the decorator pattern rules
        /// 
        /// we can now add/mix and match our various "flavours" ie decorate the orignal or default object to our hearts content. The functionality of each decoration is encapsulated within itself.
        /// 
        /// in the decorations I hardcoded the values but you can pass them in as parameters or load them from a repository, like a database.
        /// </summary>
        /// <returns></returns>
        public string BuildFullPackage()
        {
            StringBuilder sb = new StringBuilder();

            DefaultPackage defaultPackage = new DefaultPackage();
            AdditionalTravelPackage addTravel = new AdditionalTravelPackage(defaultPackage);
            MealsIncludedPackage mealsIncluded = new MealsIncludedPackage(addTravel);
            UpgradedFlightPackage upgradedFlight = new UpgradedFlightPackage(mealsIncluded);

            upgradedFlight.BuildDisplay(sb);

            sb.AppendLine(string.Empty);
            sb.AppendLine(string.Format("Total Amount: {0}", upgradedFlight.TotalValue));

            return sb.ToString();
            
        }

        public string BuildPartialPackage()
        {
            StringBuilder sb = new StringBuilder();

            DefaultPackage defaultPackage = new DefaultPackage();
            AdditionalTravelPackage addTravel = new AdditionalTravelPackage(defaultPackage);
            //MealsIncludedPackage mealsIncluded = new MealsIncludedPackage(addTravel);
            //UpgradedFlightPackage upgradedFlight = new UpgradedFlightPackage(mealsIncluded);

            addTravel.BuildDisplay(sb);

            sb.AppendLine(string.Empty);
            sb.AppendLine(string.Format("Total Amount: {0}", addTravel.TotalValue));

            return sb.ToString();
        }
    }
}
