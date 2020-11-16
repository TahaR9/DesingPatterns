using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PareDox.Patterns.AbstractFacroty.PartB
{
    //Abstract Product
    public interface IPhone
    {
        void Display();
    }
    //Concrete Product
    public class WindowPhone : IPhone
    {
        public void Display()
        {
            Console.WriteLine("Windows Phone");
        }
    }
    //Concrete Product
    public class LenovoPhone : IPhone
    {
        public void Display()
        {
            Console.WriteLine("Lenovo window Phone");
        }
    }
    //Concrete Product
    public class GooglePhone : IPhone
    {
        public void Display()
        {
            Console.WriteLine("Google Pixel 2 Phone");
        }
    }
    //Concrete Product
    public class OnePlusPhone : IPhone
    {
        public void Display()
        {
            Console.WriteLine("OnePlus Phone");
        }
    }

    //Abstract Factory
    public abstract class AbstractPhoneFactory
    {
        public static IOSFactory GetFactory(string osType)
        {
            switch (osType)
            {
                case "Window" :
                    return new WindowFactory();
                case "Android":
                    return new AndroidFactory();
                default:
                    throw new ArgumentException("Invalid Argument", osType);
            }
        }

        public abstract IPhone Create();
    }
    //Abstract Factory Interface
    public interface IOSFactory
    {
        IPhone Create(PhoneType phoneType);
    }
    public class WindowFactory : IOSFactory
    {
        public IPhone Create(PhoneType manufacturerType)
        {
            switch (manufacturerType)
            {
                case PhoneType.WINDOW:
                    return new WindowPhone();
                case PhoneType.LENOVO:
                    return new LenovoPhone();
                default:
                    throw new ArgumentException("Invalid Type", manufacturerType.ToString());
            }
        }

    }

    //Inside android factory we create android operating system phones 
    public class AndroidFactory : IOSFactory
    {
        public IPhone Create(PhoneType manufacturerType)
        {
            switch (manufacturerType)
            {
                case PhoneType.GOOGLE:
                    return new GooglePhone();
                case PhoneType.ONEPLUS:
                    return new OnePlusPhone();
                default:
                    throw new ArgumentException("Invalid Type", manufacturerType.ToString());
            }
        }
    }
    public enum Company
    {
        ANDROID,
        WINDOW
    }
    public enum PhoneType
    {
        GOOGLE,
        ONEPLUS,
        WINDOW,
        LENOVO
    }
    public class AbstractFactoryExample
    {
        public static void Main_xx(string[] args)
        {
            IOSFactory googlePhoneFactory = AbstractPhoneFactory.GetFactory("Android");
            IPhone pixel2 = googlePhoneFactory.Create(PhoneType.GOOGLE);
            pixel2.Display();
            
            IPhone onePlus = googlePhoneFactory.Create(PhoneType.ONEPLUS);
            onePlus.Display();

            IOSFactory windowPhoneFactory = AbstractPhoneFactory.GetFactory("Window");
            IPhone wPhone = windowPhoneFactory.Create(PhoneType.WINDOW);
            wPhone.Display();
            IPhone lenovo = windowPhoneFactory.Create(PhoneType.LENOVO);
            lenovo.Display();

            Console.ReadKey();
        }
    }
}
