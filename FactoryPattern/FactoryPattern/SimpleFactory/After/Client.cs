using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory.After
{
    /// <summary>
    /// much better. Now the client class no longer has to worry about how the various product type classes get instanciated.
    /// 
    /// it also does not worry about what types can be created. that's now all left to the factory.
    /// 
    /// but now, I have a question: my factory still has to distinguish between the different product types. Can I not setup my
    /// factory in such a way, taht it does not have to still decide what to created based on an incomming parameter?
    /// 
    /// what if i had multiple factories that created different objects? then whoever is invoking my client, can just choose 
    /// which factory they want up front.
    /// 
    /// Next will be a demo of two different approaches to this: the Abstract Factory and the Factory Method
    /// </summary>
    public class Client
    {
        public void DisplayStuff(string productType)
        {
            IProduct selectedProductType = ProductFactory.Create(productType);

            Console.WriteLine(selectedProductType.Display());
        }
    }
}
