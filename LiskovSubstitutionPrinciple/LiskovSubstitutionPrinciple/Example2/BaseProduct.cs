using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Example2
{
    /// <summary>
    /// whats wrong with this class? maybe nothing now, but lets say you introduce more product types or have to introduce more scenarios? what will happen to this class.... it will GROW!
    /// 
    /// the issue with these type of classes, is that although you've opened it for extention like this, you're immediately violating the SRP.
    /// 
    /// More importantly though, a class that is supposed to be stable, from a dependency point of view, is now destabelized everytime you make a change, which might be a lot since the 
    /// precedent has already been set.
    /// 
    /// To add insult to injury, because this will be growing, its memory footprint will as well. Now, where you once had a very lightweight accountpayments class, it has now become a monster.
    /// And you can't understand it.. nothing has changed in your code or in the specs of the machine it's running on.... its the baseclass
    /// 
    /// this class will also become a nightmare to maintain... you have to look either in accountpayments or in this class to find bugs... i can go on.
    /// 
    /// in almost all cases, composition (inheritance via interfaces) is preferred over inheritance (inheritance via normal or abstract classes) and you can see why. this problem would be
    /// easily solvable should we have used interfaces instead of a baseclass.
    /// 
    /// there are many other different solutions to this of course
    /// </summary>
    abstract class BaseProduct
    {
        public void SaveProduct()
        {
            if (this is Airtime)
            {
                //do something
            }

            if (this is AccountPayments)
            {
                //do something else
            }

            //save product
        }
    }
}
