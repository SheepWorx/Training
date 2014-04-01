using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstraction.Bad
{
    /*
     * consider the following: Assuming that this is a 'stable' component (component on which many components depend on)
     *  what possible risk might exist when I want to change the:
     *      Name property
     *      add a new property
     *      change any of the method signatures? 
     * 
     * What will the possible ripple effect be?
     */
    public class Product
    {
        private const decimal VAT = 0.14m;

        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }

        public string GetProductDescription()
        {
            return string.Format("Product: {0} - {1}", Name, Type);
        }

        public decimal CalculateVat()
        {
            return Amount * VAT;
        }
    }
}
