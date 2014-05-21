using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.After
{
    public class AdditionalTravelPackage: Decorator
    {
        public string Name { get; private set; }
        public decimal Value { get; private set; }

        public AdditionalTravelPackage(HolidayItem itemToBeDecorated) : base(itemToBeDecorated) 
        {
            Name = "Travel allowance for use on busses, cabs and underground";
            Value = 2000;
            TotalValue = PreviousHolidayPackage.TotalValue + Value;
        }

        public override void BuildDisplay(StringBuilder sb)
        {
            base.BuildDisplay(sb);
            sb.AppendLine(string.Format("Price: {0} - {1}", Value, Name));
        }
    }
}
