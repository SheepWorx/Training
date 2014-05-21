using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.After
{
    public abstract class HolidayItem
    {
        public decimal TotalValue { get; set; }
        public abstract void BuildDisplay(StringBuilder sb);

    }
}
