using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Examlpe3
{
    /// <summary>
    /// this is a square... kinda like a trangle except that all its sides are of equal size.
    /// so.. is what we're doing here wrong? Not that I can see
    /// 
    /// Let's run a unit test for rectangle and see if anything breaks....
    /// </summary>
    public class Square: Rectangle
    {
        public override void SetHeight(int height)
        {
            base.SetHeight(height);
            base.SetWidth(height);
        }

        public override void SetWidth(int width)
        {
            base.SetHeight(width);
            base.SetWidth(width);
        }
    }
}
