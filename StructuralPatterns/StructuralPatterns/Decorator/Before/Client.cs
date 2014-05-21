using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.Before
{
    public class Client
    {
        public string HolidayPackageBuilder()
        {
            bool additionlTravel = true,
                mealsIncluded = true,
                upgradedFlightClass = true;

            return BuildPackage(additionlTravel, mealsIncluded, upgradedFlightClass);
        }

        private string BuildPackage(bool additionlTravel, bool mealsIncluded, bool upgradedFlightClass)
        {
            IList<HolidayItem> listOfPackages = new List<HolidayItem>();

            HolidayItem defaultPackage = new HolidayItem() { Name = "Flight with 3 night's stay in London", Value = 10000 };
            listOfPackages.Add(defaultPackage);

            if (additionlTravel)
            {
                HolidayItem additionalTravelPackage = new HolidayItem() { Name = "Travel allowance for use on busses, cabs and underground", Value=2000 };
                listOfPackages.Add(additionalTravelPackage);
            }

            if (mealsIncluded)
            {
                HolidayItem mealsIncludedPackage = new HolidayItem() { Name = "All meals at hotel included", Value = 600 };
                listOfPackages.Add(mealsIncludedPackage);
            }

            if (upgradedFlightClass)
            {
                HolidayItem upgradedFlightClassPackage = new HolidayItem() { Name = "Flight to and from London in First Class", Value = 8000 };
                listOfPackages.Add(upgradedFlightClassPackage);
            }

            StringBuilder sb = new StringBuilder();
            decimal total = 0;

            sb.AppendLine("Details of your holiday package");
            sb.AppendLine(string.Empty);

            foreach (HolidayItem item in listOfPackages)
            {
                sb.AppendLine(string.Format("Price: {0} - {1}", item.Value, item.Name));
                total += item.Value;
            }

            sb.AppendLine(string.Empty);
            sb.AppendLine(string.Format("Total Amount: {0}", total));

            return sb.ToString();
        }
    }
}
