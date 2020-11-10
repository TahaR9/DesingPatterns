using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory2
{
    /*
     *Assingment # 2
        We have a Faculty Member, who is been given task in each semester prepare a course folder.
        Course folder consists of following item : 
                1 - Assingments
                    - Top Marks Assingment
                    - Average Assingment
                    - Below Average Assingment
                    - Model Assingment
                    - Assingment Content Document
                2  - Quizes
                     - Question Paper
                     - Model Solution
                     - Above
                     - Average
                     - Below Average
                3  - Sessionals
                     Sessional-1
                        - Question Paper
                        - Model Solution
                        - Above
                        - Average
                        - Below Average
                     Sessional-2
                        - Question Paper
                        - Model Solution
                        - Above
                        - Average
                        - Below Average
                4  - Final
                    - Question Paper
                        - Model Solution
                        - Above
                        - Average
                        - Below Average
     
    */


    public interface Product
    {
    }
    public class ConcreteProductA : Product
    {
    
    }

    public class ConcreteProductB : Product
    {

    }

    public class ConcreteProductC : Product
    {

    }
    public abstract class Factory
    {
        public abstract Product CreateProduct(string type);
    }

    public class ConcreteCreator : Factory
    {
        public override Product CreateProduct(string type)
        {
            switch (type)
            {
                case "A":
                    return new ConcreteProductA();
                case "B":
                    return new ConcreteProductB();
                case "C":
                    return new ConcreteProductC();

                default:
                    throw new ArgumentException("Invalid type", type);
            }
        }
    }
    public class FactoryMethodClient
    {
        public static void Main_001(string[] args)
        {
            Factory factory = new ConcreteCreator();
            
            Product product = factory.CreateProduct("A");
            Console.WriteLine("Type  : " + product.GetType().Name);
            
            product = factory.CreateProduct("B");
            Console.WriteLine("Type  : " + product.GetType().Name);

            product = factory.CreateProduct("C");

            Console.WriteLine("Type  : " + product.GetType().Name);


            Console.ReadKey();
        }
    }
}
