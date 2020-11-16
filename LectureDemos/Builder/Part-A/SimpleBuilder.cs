using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareDox.Patterns.Builder.PartA
{
    /*
        Examination Builder Pattern

        Result : 
            Representation 1 =>    Build paper : MCQs, True/False, Fill Blanks
            Representation 2 =>    Build paper : MCQs, Short Question, Fill Blanks
            Representation 3 =>    Build paper : MCQs, True/False, Short Questions
     */

    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string PartC { get; set; }
    }
    public interface IBuilder
    {
       void AddPart1();
       void AddPart2();
       void AddPart3();
       void Build();
    }

    public class ConcreteBuilder : IBuilder
    {
        Product product = new Product();
        public void AddPart1()
        {
            product.PartA = "Headlight";
            Console.WriteLine("Headlight added");
        }

        public void AddPart2()
        {
            product.PartB = "Body added";
            Console.WriteLine("Body added");
        }

        public void AddPart3()
        {
            product.PartC = "Battery Added";
            Console.WriteLine("Battery Installed");
        }

        public void Build()
        {
            AddPart1();
            AddPart2();
            AddPart3();
        }
        public Product GetProduct()
        {
            return product;
        }
    }
    public class Director
    {
        IBuilder Builder;
        public Director(IBuilder builder )
        {
            Builder = builder;
        }
        public void Construct()
        {
            Builder.Build(); 
        }
    }

    public class ExecuteDemo
    {
        public static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            var p = builder.GetProduct();

            Console.WriteLine("Part A : " + p.PartA);
            Console.WriteLine("Part B : " + p.PartB);
            Console.WriteLine("Part C : " + p.PartC);

            Console.ReadKey();
        }
    }
}
