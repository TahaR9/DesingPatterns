using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
   Real World Example : COMSATS University Examination 
   Evaluation and Assessment Test Types 
*/
namespace Exam.AbstractFactory.PartB
{
    //Product for Examination  
    public abstract class TestType
    {
        private string _Title { get; set; }
        public string Title => _Title;
        public TestType(string title)
        {
            _Title = title;
        }
    }
    public class Assignment : TestType
    {
        public Assignment(string title) : base(title) { }

    }
    public class Quiz : TestType
    {
        public Quiz(string title) : base(title) { }
    }
    public class Sessional : TestType
    {
        public Sessional(string title) : base(title) { }
    }
    public class Final : TestType
    {
        public Final(string title) : base(title) { }
    }
    public class Other : TestType
    {
        public Other(string title) : base(title) { }
    }
    public abstract class TestFactory
    {
        private string _Title { get; set; }
        public string Title => _Title;

        private List<TestType> _Tests = new List<TestType>();
        public List<TestType> Tests => _Tests;

        public TestFactory(string title)
        {
            _Title = title;
            this.Create();
        }
        public abstract void Create();
    }
    public class AllTestFactory : TestFactory
    {
        public AllTestFactory(string title) : base(title) { }
        public override void Create()
        {
            Tests.Add(new Assignment("Assignment - 1"));
            Tests.Add(new Assignment("Assignment - 2"));
            Tests.Add(new Assignment("Assignment - 3"));
            Tests.Add(new Assignment("Assignment - 4"));
            Tests.Add(new Quiz("Quiz - 1"));
            Tests.Add(new Quiz("Quiz - 2"));
            Tests.Add(new Quiz("Quiz - 3"));
            Tests.Add(new Quiz("Quiz - 4"));
            Tests.Add(new Sessional("Sessional - 1"));
            Tests.Add(new Sessional("Sessional - 2"));
            Tests.Add(new Final("Fianl Term"));
            Tests.Add(new Other("Other type"));
        }
    }
    public class AssignmentFactory : TestFactory
    {
        public AssignmentFactory(string title) : base(title) { }
        public override void Create()
        {
            Tests.Add(new Assignment("Assignment - 1"));
            Tests.Add(new Assignment("Assignment - 2"));
            Tests.Add(new Assignment("Assignment - 3"));
            Tests.Add(new Assignment("Assignment - 4"));

        }
    }
    public class QuizFactory : TestFactory
    {
        public QuizFactory(string title) : base(title) { }
        public override void Create()
        {
            Tests.Add(new Quiz("Quiz - 1"));
            Tests.Add(new Quiz("Quiz - 2"));
            Tests.Add(new Quiz("Quiz - 3"));
            Tests.Add(new Quiz("Quiz - 4"));
        }
    }
    public class SessionalFactory : TestFactory
    {
        public SessionalFactory(string title) : base(title) { }
        public override void Create()
        {
            Tests.Add(new Sessional("Sessional - 1"));
            Tests.Add(new Sessional("Sessional - 2"));
        }
    }
    public class FinalTermFactory : TestFactory
    {
        public FinalTermFactory(string title) : base(title) { }
        public override void Create()
        {
            Tests.Add(new Final("Final Term"));
        }
    }

    //Client that creates factories
    public abstract class ExamFactory
    {
        //static string examTitle = string.Format("{0} {1}", DateTime.Now.Month > 6 ? "Fall" : "Spring", DateTime.Now.Year);
        //Eager loading...
        static List<TestFactory> exams = new List<TestFactory>()
        {
            new AllTestFactory("Fall 2020"),
            new AssignmentFactory("Fall 2020"),
            new QuizFactory("Fall 2020"),
            new SessionalFactory("Fall 2020"),
            new FinalTermFactory("Fall 2020")
        };
        public static TestFactory GetTestFactory(Type type)
        {
            return exams.FirstOrDefault(x => x.GetType() == type);
        }
        public static void DisplayTestDetails(List<TestFactory> factories)
        {
            var index = 1;
            foreach (var exam in factories)
            {
                Console.WriteLine("\n" + $"{index++}.  {exam.Title}  -  {exam.GetType().Name}");
                foreach (var test in exam.Tests)
                {
                    Console.WriteLine("".PadRight(10) + $".  {test.Title}  -  {test.GetType().Name}");
                }
            }
        }
    }
    public class ExamClient
    {
        public static void Main_MM(string[] args)
        {
            //List<TestFactory> examFactory = new List<TestFactory>();
            //TestFactory factory = null;
            //factory = new AssignmentFactory("Fall 2020");
            //examFactory.Add(factory);

            //factory = new QuizFactory("Fall 2020");
            //examFactory.Add(factory);

            //factory = new SessionalFactory("Fall 2020");
            //examFactory.Add(factory);

            //factory = new FinalTermFactory("Fall 2020");
            //examFactory.Add(factory);


            //List<TestFactory> examFactory = new List<TestFactory>()
            //{
            //    new AllTestFactory("Fall 2020"),
            //    new AssignmentFactory("Fall 2020"),
            //    new QuizFactory("Fall 2020"),
            //    new SessionalFactory("Fall 2020"),
            //    new FinalTermFactory("Fall 2020")
            //};

            List<TestFactory> examFactories = new List<TestFactory>()
            {
                ExamFactory.GetTestFactory(typeof(AllTestFactory)),
                ExamFactory.GetTestFactory(typeof(AssignmentFactory)),
                ExamFactory.GetTestFactory(typeof(QuizFactory)),
                ExamFactory.GetTestFactory(typeof(SessionalFactory)),
                ExamFactory.GetTestFactory(typeof(FinalTermFactory))
            };

            ExamFactory.DisplayTestDetails(examFactories);

            Console.ReadKey();
        }
    }
}
