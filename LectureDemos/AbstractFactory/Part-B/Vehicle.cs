using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

/*
    A virtual vehicle outlet company "World Virtual Wheels" deals with different manufacturing companies
    in order to manufacture different types of vehicles.
    
    This outlet works just like a virtual factory that brings oders to the real manufacturers for buiding vehicles
    based on demand of the marketplace.
    
    The actual vehicle menufacturers got very enthusiastic about the idea floated by the "World Virtual Wheels"
    To avail this opportunity, menufacturers start getting orders in a smoother way by isolating themselves 
    from investing their efforts and money in the marketplace to reach customers directly.
    
    This way of doing business by manufacturer focus their attention towards their core work and confines 
    them strictly to restrain in their own domain to be responsible only for manufacturing vehicles.
    
    The same is true for the "World Virtual Wheels", they actually will not be manufacturing vehicles but
    focusing their attention to bringing order of vehicles to be manufactured by manufacturing companies. 
    
    The relationship between virtual outlet company and manufactering companies is loosely bound, means that if there 
    is no demand there no manufacturing.This also mean that a vehicle menufacturer and virtual outlet are independent.
    At any time both can disagree to do business in this context and walkout independly without dismentally each other.
*/


namespace PareDox.Patterns.AbstractFactory.PartB
{
    public interface ICar
    {

    }
    public class HondaCity : ICar
    {
        
    }
    public class HondaCivic : ICar
    {

    }

    public interface ITruck
    {

    }
    public class ValcanoTruck : ITruck
    {

    }
    public class WontonTruck : ITruck
    {

    }
    public class HiLandTruck : ITruck
    {

    }
    public class LandMarkTruck : ITruck
    {

    }
    public class ToyotaXli : ICar  
    {

    }
    public class ToyotaGli : ICar
    {

    }
    public class ToyotaCorolla : ICar
    {

    }

    public interface IVehicleFactory
    {
        ITruck GetTruck(string variant);
        ICar GetCar(string variant);
    }
    public class HondaFactory : IVehicleFactory
    {
        public ITruck GetTruck(string variant)
        {
            switch (variant)
            {
                case "Valcano":
                    return new ValcanoTruck();
                case "Wonton":
                    return new WontonTruck();
                default:
                    throw new ArgumentException("Invalid Variant", variant);
            }
        }

        public ICar GetCar(string variant)
        {
            switch (variant)
            {
                case "City":
                    return new HondaCity();
                case "Civic":
                    return new HondaCivic();
                default:
                    throw new ArgumentException("Invalid Variant", variant);
            }
        }
    }
    public class ToyotaFactory : IVehicleFactory
    {
        public ITruck GetTruck(string variant)
        {
            switch (variant)
            {
                case "TruckA":
                    return new HiLandTruck();
                case "TruckB":
                    return new LandMarkTruck();
                default:
                    throw new ArgumentException("Invalid Variant", variant);
            }
        }

        public ICar GetCar(string variant)
        {
            switch (variant)
            {
                case "Xli":
                    return new ToyotaXli();
                case "Gli":
                    return new ToyotaGli();
                case "Corolla":
                    return new ToyotaCorolla();
                default:
                    throw new ArgumentException("Invalid Variant", variant);
            }
        }
    }
    public abstract class Client
    {
        public static IVehicleFactory GetFactory(string type)
        {
            switch (type)
            {
                case "Honda":
                    return new HondaFactory();
                case "Toyota":
                    return new ToyotaFactory();
                default:
                    throw new ArgumentException("Invalid Factory Type", type);
            }
        }
    }

    public class ExecuteDemo
    {
        public static void Main_xx(string[] args)
        {
            IVehicleFactory hondaFactory = Client.GetFactory("Honda");
            var city = hondaFactory.GetCar("City");
            Console.WriteLine(city.GetType().Name);
            var truck = hondaFactory.GetTruck("Valcano");
            Console.WriteLine(truck.GetType().Name);

            IVehicleFactory toyotaFactory = Client.GetFactory("Toyota");
            var gli = toyotaFactory.GetCar("Gli");
            Console.WriteLine(gli.GetType().Name);
            truck = toyotaFactory.GetTruck("TruckB");
            Console.WriteLine(truck.GetType().Name);
            Console.ReadKey();
        }
    }
}
