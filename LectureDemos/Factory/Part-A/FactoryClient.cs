using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.PartA
{
    public class FactoryClient
    {
        public static void Main_ooa(string[] args)
        {
            Creator creator = new ConcreteCreator();

            Product product = creator.FactoryMethod("A");
            Console.WriteLine("Product " + product.GetType().Name + " created");

            product = creator.FactoryMethod("B"); 
            Console.WriteLine("Product " + product.GetType().Name + " created");
            

            Console.ReadKey();
        }
    }
}
