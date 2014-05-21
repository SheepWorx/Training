using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.After
{
    public class DefaultPackage : HolidayItem
    {
        public string Name { get; private set; }
        public decimal Value { get; private set; }

        /// <summary>
        /// i hardcoded the info here but you would either take it in as parameters or load it from a database or something
        /// </summary>
        public DefaultPackage()
        {
            Name = "Flight with 3 night's stay in London";
            Value = 10000;
            TotalValue +=Value;
        }

        public override void BuildDisplay(StringBuilder sb)
        {
            sb.AppendLine("Details of your holiday package");
            sb.AppendLine(string.Empty);
            sb.AppendLine(string.Format("Price: {0} - {1}", Value, Name));
        }
    }
}
