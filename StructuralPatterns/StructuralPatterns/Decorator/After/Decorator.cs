using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.After
{
    public class Decorator: HolidayItem
    {
        protected HolidayItem PreviousHolidayPackage { get; set; }

        public Decorator(HolidayItem itemToBeDecorated)
        {
            PreviousHolidayPackage = itemToBeDecorated;
        }

        public override void BuildDisplay(StringBuilder sb)
        {
            PreviousHolidayPackage.BuildDisplay(sb);
        }
    }
}
