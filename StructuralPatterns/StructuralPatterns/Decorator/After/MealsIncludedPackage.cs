using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.After
{
    public class MealsIncludedPackage : Decorator
    {
        public string Name { get; private set; }
        public decimal Value { get; private set; }

        public MealsIncludedPackage(HolidayItem itemToBeDecorated) : base(itemToBeDecorated) 
        {
            Name = "All meals at hotel included";
            Value = 600;
            TotalValue = PreviousHolidayPackage.TotalValue + Value;
        }

        public override void BuildDisplay(StringBuilder sb)
        {
            base.BuildDisplay(sb);
            sb.AppendLine(string.Format("Price: {0} - {1}", Value, Name));

            
        }
    }
}
