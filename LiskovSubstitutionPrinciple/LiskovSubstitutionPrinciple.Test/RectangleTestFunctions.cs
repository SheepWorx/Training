using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple.Examlpe3;

namespace LiskovSubstitutionPrinciple.Test
{
    public static class RectangleTestFunctions
    {
        public static Rectangle GetNewRectangle()
        {
            return new Square();
        }
    }
}
