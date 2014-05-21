using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.After
{
    public class UpgradedFlightPackage : Decorator
    {
        public string Name { get; private set; }
        public decimal Value { get; private set; }

        public UpgradedFlightPackage(HolidayItem itemToBeDecorated) : base(itemToBeDecorated) 
        {
            Name = "Flight to and from London in First Class";
            Value = 8000;
            TotalValue = PreviousHolidayPackage.TotalValue + Value;
        }

        public override void BuildDisplay(StringBuilder sb)
        {
            base.BuildDisplay(sb);
            sb.AppendLine(string.Format("Price: {0} - {1}", Value, Name));
        }
    }
}
