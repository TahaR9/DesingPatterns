using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.PartA
{
    public interface Product { }
    public class ConcreteProductA : Product { }
    public class ConcreteProductB : Product { }
    public abstract class Creator
    {
        public abstract Product FactoryMethod(string type);
    }

    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(string type)
        {
            switch (type)
            {
                case "A":
                    return new ConcreteProductA();

                case "B":
                    return new ConcreteProductB();
                default:
                    throw new ArgumentException("Invalid type", type);
                    
            }
        }
    }
}
