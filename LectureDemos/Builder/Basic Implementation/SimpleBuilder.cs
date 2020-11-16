using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareDox.Patterns.Builder
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }
    }
    public interface IBuilder
    {
        IBuilder AddPart1();
        IBuilder AddPart2();
        IBuilder AddPart3();
        Product GetProduct();
    }
    public class ConcreteBuilder : IBuilder
    {
        Product product = new Product();
        public IBuilder AddPart1()
        {
            product.Part1 = "Part1";
            return this;
        }

        public IBuilder AddPart2()
        {
            product.Part2 = "Part2";
            return this;
        }

        public IBuilder AddPart3()
        {
            product.Part3 = "Part3";
            return this;
        }

        public Product GetProduct()
        {
            return product;
        }
    }
    public class Director
    {
        readonly IBuilder Builder;
        public Director(IBuilder builder)
        {
            Builder = builder;
        }
        public void Build()
        {
            Builder.AddPart1().AddPart2().AddPart3();
        }
        public Product GetProduct()
        {
            return Builder.GetProduct();
        }
    }
    public class BuilderDemo
    {
        public static void Mainxxx(string[] args)
        {
            Director director = new Director(new ConcreteBuilder());
            director.Build();
            var product = director.GetProduct();
            Console.WriteLine($"{product.Part1}, {product.Part2}, {product.Part3}");
            Console.ReadKey();
        }

    }
}
