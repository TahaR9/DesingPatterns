/*
    Lab-sessional-1 30 Marks
    
    As we have studied in earlier lectures that the singleton pattern can be used for 
    anything that you don't want to repeat. 
    More specifically, if the object in question is not expected to change, 
    it is a good candidate for the singleton pattern. 

    The programming situation given below depicts the scenario of a signleton pattern.
    In a sigle user operating system the user component is required to be built.
    You are hired as a software developer to build the component with the rquirements
    given as:
        1. The user needs to singin with username and password
        2. The same user will have acces to all parts of the system.
        
    Write a component using C# and use that component in your program to demonstrate
    the follwoing two scenario of singleton pattern.
      1. Simple Scenario
      2. Multi-threaded Scenario
 */
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Factory.PartB
{
    public abstract class Test
    {
        private string _Title { get; set; }
        public string Title => _Title;
        public Test(string title)
        {
            _Title = title;
        }
    }
    public class Assignment : Test
    {
        public Assignment(string title) : base(title) { }
    }
    public class Quiz : Test
    {
        public Quiz(string title) : base(title) { }

    }
    public class Sessional : Test
    {
        public Sessional(string title) : base(title) { }

    }
    public class Final : Test
    {
        public Final(string title) : base(title) { }

    }

    public abstract class ExamFactory
    {
        List<Test> _Tests = new List<Test>();
        public List<Test> Tests => _Tests;
        string _Title { set; get; }
        public string Title => _Title;
        public ExamFactory(string title)
        {
            _Title = title; 
            this.Create();
        }
        public abstract void Create();
    }
    public class Exam : ExamFactory
    {
        public Exam(string title) : base(title) { }
        public override void Create()
        {
            Tests.Add(new Assignment("Assignemnt-1"));
            Tests.Add(new Assignment("Assignemnt-2"));
            Tests.Add(new Assignment("Assignemnt-3"));
            Tests.Add(new Assignment("Assignemnt-4"));
            Tests.Add(new Quiz("Quiz-1"));
            Tests.Add(new Quiz("Quiz-2"));
            Tests.Add(new Quiz("Quiz-3"));
            Tests.Add(new Quiz("Quiz-4"));
            Tests.Add(new Sessional("Sessional-1"));
            Tests.Add(new Sessional("Sessional-2"));
            Tests.Add(new Final("Final Term"));
        }
    }

    public class ExamClient
    {
        public static void Main_Test(string[] args)
        {
            List<ExamFactory> exams = new List<ExamFactory>
            {
                new Exam("Spring 2020"),
                new Exam("Fall 2020")
            };
            var index = 1;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string circle = "\u2192"; //right arrow
            exams.ForEach(exam =>
            {
                Console.WriteLine("\n" + "".PadRight(5) + $"{index++}. {exam.Title}" + " - " + exam.GetType().Name);
                exam.Tests.ForEach(test =>
               {
                   Console.WriteLine("".PadLeft(10) + $"{circle} {test.Title}" + " - " + test.GetType().Name);
               });
            });
            
            Console.ReadKey();
        }
    }

}
