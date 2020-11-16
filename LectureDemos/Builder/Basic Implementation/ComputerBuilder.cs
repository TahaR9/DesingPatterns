using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareDox.Patterns.Builder.Basics
{
    public class Computer
    {
        public string Ram { get; set; }
        public string HDD { get; set; }
        public string Processor { get; set; }
    }
    public interface IComputerBuilder
    {
        IComputerBuilder AddProcessor(string processor);
        IComputerBuilder AddRam(string ram);
        IComputerBuilder AddHDD(string hdd);
        Computer GetComputer();
    }
    public class ComputerBuilder : IComputerBuilder
    {
        private readonly Computer computer = new Computer();
        public IComputerBuilder AddHDD(string hdd)
        {
            computer.HDD = hdd;
            return this;
        }

        public IComputerBuilder AddProcessor(string processor)
        {
            computer.Processor = processor;
            return this;
        }

        public IComputerBuilder AddRam(string ram)
        {
            computer.Ram = ram;
            return this;
        }
        public Computer GetComputer()
        {
            return computer;
        }
    }
    public class SystemDirector
    {
        IComputerBuilder Builder { get; set; }
        public SystemDirector(IComputerBuilder builder)
        {
            Builder = builder;
        }

        public IComputerBuilder Build()
        {
            Builder.AddHDD("500 GB");
            Builder.AddRam("8 GB");
            Builder.AddProcessor("Core I7");
            return Builder;
        }

        public Computer GetComputer()
        {
            return Builder.GetComputer();
        }
    }

    public class ExecuteDemo
    {
        public static void Mainxxx(string[] args)
        {
            var builder = new ComputerBuilder();
            SystemDirector director = new SystemDirector(builder);
            director.Build();
            var system = builder.GetComputer();
            Console.WriteLine($"Ram : {system.Ram}, HDD : {system.HDD}, Processor : {system.Processor}");
            Console.ReadKey();
        }
    }

}
