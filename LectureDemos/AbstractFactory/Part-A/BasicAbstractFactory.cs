using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareDox.Patterns.AbstractFactory.Implementation.Basic
{
    public interface ProductA
    {

    }
    public class ProductA1 : ProductA
    {

    }
    public class ProductA2 : ProductA
    {

    }
    public interface ProductB
    {

    }
    public class ProductB1 : ProductB
    {

    }
    public class ProductB2 : ProductB
    {

    }
    public interface AbstractFactory
    {
        ProductA CreateProductA();
        ProductB CreateProductB();
    }
    public class ConcreteFactory1 : AbstractFactory
    {
        public ProductA CreateProductA()
        {
            //Console.WriteLine("ProductA1 is created");
            var product =  new ProductA1();
            Console.WriteLine(product.GetType().Name + " is created in concrete factory 1");
            return product;
        }

        public ProductB CreateProductB()
        {
            Console.WriteLine("ProductB1 is created in concrete factory 1");
            return new ProductB1();
        }
    }
    public class ConcreteFactory2 : AbstractFactory
    {
        public ProductA CreateProductA()
        {
            Console.WriteLine("ProductA2 is created in concrete factory 2");
            return new ProductA2();
        }

        public ProductB CreateProductB()
        {
            Console.WriteLine("ProductB2 is created in concrete factory 2");
            return new ProductB2();
        }
    }
    public enum FactoryType
    {
        FACTORY1,
        FACTORY2
    }
    public abstract class Client
    {
        public static AbstractFactory GetFactory(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.FACTORY1:
                    return new ConcreteFactory1();
                case FactoryType.FACTORY2:
                    return new ConcreteFactory2();
                default:
                    throw new ArgumentException("Invalid type factory", type.ToString());
            }
        }      
    }
    public class ExecuteDemo
    {
        public static void Mainxxx(string[] args)
        {
            //Client client1  = new Client(new ConcreteFactory1());
            //client1.Factory.CreateProductA();
            //client1.Factory.CreateProductB();

            //Client client2 = new Client(new ConcreteFactory2());
            //client2.Factory.CreateProductA();
            //client2.Factory.CreateProductB();

            AbstractFactory factory1 = Client.GetFactory(FactoryType.FACTORY1);
            factory1.CreateProductA();
            factory1.CreateProductB();
            AbstractFactory factory2 = Client.GetFactory(FactoryType.FACTORY2);
            factory2.CreateProductA();
            factory2.CreateProductB();
            Console.ReadKey();
        }
    }
}
