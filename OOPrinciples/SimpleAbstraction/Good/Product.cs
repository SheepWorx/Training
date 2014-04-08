using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstraction.Good
{
    /// <summary>
    /// this is better. Product DTO is abstracted and reusuable by other components
    /// 
    /// if other components need addtional fields, the change can be made here and it won't affect the product functions (unless you go and remove properties it needs)
    ///  - always important to have unit tests in place that ensure the signature of your class (in the case that it's shared).
    /// </summary>
    public class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }
}
