using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Lecture Section B
    On Friday 13 Nov, 2019
*/

namespace PareDox.Patterns.AbstractFactory.WhatMobile
{
    public enum PhoneNames
    {
        GALAXYFOLD,
        GALAXYFOLDZ,
        RENO3,
        RENO4
    }

    //Simple Product A interface
    public interface IPhone
    {

    }
    public class GalaxyFold : IPhone
    {

    }
    public class GalaxyFoldZ : IPhone
    {

    }
    public class Reno3 : IPhone
    {

    }
    public class Reno4 : IPhone
    {

    }
    public interface IFactory
    {
        IPhone CreatePhone(PhoneNames which);
    }
    public class Samsung : IFactory
    {
        public IPhone CreatePhone(PhoneNames which)
        {
            switch (which)
            {
                case PhoneNames.GALAXYFOLD:
                    Console.WriteLine("GalaxyFold phone is created in Samsung Factory");
                    return new GalaxyFold();
                case PhoneNames.GALAXYFOLDZ:
                    Console.WriteLine("GalaxyFoldZ phone is created in Samsung Factory");
                    return new GalaxyFoldZ();
                default:
                    throw new ArgumentException("Invalid product", which.ToString());

            }
        }
    }
    public class Oppo : IFactory
    {
        public IPhone CreatePhone(PhoneNames which)
        {
            switch (which)
            {
                case PhoneNames.RENO3:
                    Console.WriteLine("Reno3 phone is created in Oppo factory");
                    return new Reno3();
                case PhoneNames.RENO4:
                    Console.WriteLine("Reno4 phone is created in Oppo factory");
                    return new Reno4();
                default:
                    throw new ArgumentException("Invalid product", which.ToString());

            }
        }
    }
    public class Client
    {
        IFactory Factory;
        public Client(IFactory factory)
        {
            Factory = factory;
        }

        public IFactory GetFactory()
        {
            return Factory;
        }
    }
    public class ExecuteDemo
    {
        public static void Mainxxx(string[] args)
        {
            Client client = new Client(new Samsung());
            var samsungFactory = client.GetFactory();
            client = new Client(new Oppo());
            var oppoFactory = client.GetFactory();

            List<IPhone> samsungPhone = new List<IPhone>
            {
                samsungFactory.CreatePhone(PhoneNames.GALAXYFOLD),
                samsungFactory.CreatePhone(PhoneNames.GALAXYFOLD),
                samsungFactory.CreatePhone(PhoneNames.GALAXYFOLD),
                samsungFactory.CreatePhone(PhoneNames.GALAXYFOLD),
                samsungFactory.CreatePhone(PhoneNames.GALAXYFOLDZ),
                samsungFactory.CreatePhone(PhoneNames.GALAXYFOLDZ),
                samsungFactory.CreatePhone(PhoneNames.GALAXYFOLDZ),
                oppoFactory.CreatePhone(PhoneNames.RENO3),
                oppoFactory.CreatePhone(PhoneNames.RENO3),
                oppoFactory.CreatePhone(PhoneNames.RENO3),
                oppoFactory.CreatePhone(PhoneNames.RENO4),
                oppoFactory.CreatePhone(PhoneNames.RENO4),
                oppoFactory.CreatePhone(PhoneNames.RENO4),
            };
            Console.ReadKey();
        }
    }
}
