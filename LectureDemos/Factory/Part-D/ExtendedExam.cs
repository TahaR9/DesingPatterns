using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Exam.Groups.Factory
{
    /*
       Adding Students, Groups and Report to the solution in a Factory Method Context
       ==============================================================================
       1. System must provide Adding Students functionality.
       2. Student are required to be managed in Groups.
       3. System must have also ability to show different examination reports.

       -> Initially we created COMSATS University Exam Framework. The objective was to 
          implement Factory Method Design Pattern.
       -> Now it is required to incoporate new requirements given above in the already 
          built system.
       -> Our already system is designed well and we have implemented the required 
          Design Patterns. 
       -> Extending our system to next level by incorporating new functionalies should
          not be too difficult.
       -> 

    */

    //Student
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string CourseTitle { get; set; }

    }
    //Groups Component
    public abstract class Group
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public string GroupTitle { get; private set; }
        public Group(string title)
        {
            GroupTitle = title;
            this.AddStudents();
        }

        /*
         * Why virtual and not an abstract function?
         * If there is some default data, use virtual function otherwise 
         * have an abstract function 
        */
        public virtual void AddStudents()
        {
            //You can fetch students from the database 
            Students.Add(new Student() { StudentID = 1, FullName = "Aamir Pare", CourseTitle = "Design Pattern" });
            Students.Add(new Student() { StudentID = 2, FullName = "Mishal Pare", CourseTitle = "Design Pattern" });
            Students.Add(new Student() { StudentID = 3, FullName = "Sara Pare", CourseTitle = "Design Pattern" });
            Students.Add(new Student() { StudentID = 4, FullName = "Rashida Kazmi", CourseTitle = "Design Pattern" });
            Students.Add(new Student() { StudentID = 5, FullName = "Sumreena Khan", CourseTitle = "Design Pattern" });
        }

        public virtual void DisplayStudents()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var arrow = "\u3164";
            Console.WriteLine("".PadRight(15) + $"{arrow}  {GroupTitle }");
            foreach (var s in Students)
            {
                Console.WriteLine("".PadRight(20) + $".  { s.StudentID }, {s.FullName}");
            }
        }
    }
    public class GroupA : Group
    {
        public GroupA(string title) : base(title) { }
    }
    public class GroupB : Group
    {
        public GroupB(string title) : base(title) { }
        public override void AddStudents()
        {
            Students.Add(new Student() { StudentID = 12, FullName = "Ramesh", CourseTitle = "Object Oriented Programming" });
            Students.Add(new Student() { StudentID = 13, FullName = "Amjad Kumar", CourseTitle = "Object Oriented Programming" });
            Students.Add(new Student() { StudentID = 14, FullName = "Ram Das Sinha", CourseTitle = "Object Oriented Programming" });
            Students.Add(new Student() { StudentID = 15, FullName = "Dr. Vinod Tripathi", CourseTitle = "Object Oriented Programming" });
        }
    }
    public class GroupC : Group
    {
        public GroupC(string title) : base(title) { }

        public override void AddStudents()
        {
            Students.Add(new Student() { StudentID = 6, FullName = "Soman Ali", CourseTitle = "Algorithm and Data Structures" });
            Students.Add(new Student() { StudentID = 7, FullName = "Rajander Kumar", CourseTitle = "Algorithm and Data Structures" });
            Students.Add(new Student() { StudentID = 8, FullName = "Karan Johar", CourseTitle = "Algorithm and Data Structures" });
            Students.Add(new Student() { StudentID = 9, FullName = "Salman Raja", CourseTitle = "Algorithm and Data Structures" });
        }

    }

    //Product for Examination  
    public abstract class Test
    {
        protected virtual List<Group> _Groups { get; set; } = new List<Group>();
        public List<Group> Groups => _Groups;
        private string _Title { get; set; }
        public string Title => _Title;
        public Test(string title)
        {
            _Title = title;
        }
        public virtual void Display()
        {
            Console.WriteLine("".PadRight(10) + $"\u2192 {Title}  -  {this.GetType().Name}");
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
    public class Other : Test
    {
        public Other(string title) : base(title) { }
    }

    //Factory for Examination 
    public abstract class Exam
    {
        private string _Title { get; set; }
        public string Title => _Title;

        private List<Test> _Tests = new List<Test>();
        public List<Test> Tests => _Tests;

        public Exam(string title)
        {
            _Title = title;
            this.Create();
        }
        public virtual Test GetTestByTitle(string title)
        {
            return Tests.Find(t => t.Title == title);
        }
        public abstract void Create();
    }
    public class ExamFactory : Exam
    {
        public ExamFactory(string title) : base(title) { }
        private void CreateTests()
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
        private void CreateGroups()
        {
            //Create Groups in the factory
            //The assignment is given to multiple groups i.e A, B, C
            var assingment1 = Tests.Find(x => x.Title == "Assignment - 1");
            assingment1.Groups.Add(new GroupA("Section A"));
            assingment1.Groups.Add(new GroupB("Section B"));
            assingment1.Groups.Add(new GroupC("Section C"));

            //Tests[1] - Assignment two is given to Group B  
            Tests[1].Groups.Add(new GroupB("Section B"));
            //OR
            //Tests.Find(t => t.Title == "Assignment - 2")
            //     .Groups.Add(new GroupB("Section B"));

            //Tests[2] - Assignment three is given to Group C
            Tests[2].Groups.Add(new GroupC("Section C"));

            Tests.Find(t => t.Title == "Quiz - 1" && t.GetType() == typeof(Quiz))
                 .Groups.Add(new GroupA("Section A"));

        }
        public override void Create()
        {
            this.CreateTests();
            this.CreateGroups();
        }
    }

    //Report Component
    public interface IExamReport
    {
        void AssignmentReport(Test test);
        void AssignmentReport(string title);
        void QuizReport(Test test);
        void QuizReport(string title);
        void AllAssignmentReport();
        void AllQuizReport();

        void GetExamReport(Type type, string Title = "Examination Report");
    }
    public class ExamReport : IExamReport
    {
        private readonly Exam Exam;
        public ExamReport(Exam exam)
        {
            Exam = exam;
        }
        public void AssignmentReport(Test test)
        {
            this.AssignmentReport(test.Title);
        }
        public void AssignmentReport(string title)
        {
            var test = Exam.Tests.Find(t => t.Title == title && t.GetType() == typeof(Assignment));
            test.Display();
            foreach (var g in test.Groups)
            {
                g.DisplayStudents();
            }
        }
        public void AllAssignmentReport()
        {
            foreach (var assignment in Exam.Tests.Where(x => x.GetType() == typeof(Assignment)))
            {
                this.AssignmentReport(assignment);
            }
        }
        public void QuizReport(Test test)
        {
            QuizReport(test.Title);
        }
        public void QuizReport(string title)
        {
            var test = Exam.Tests.Find(t => t.Title == title && t.GetType() == typeof(Quiz));
            test.Display();
            foreach (var g in test.Groups)
            {
                g.DisplayStudents();
            }
        }
        public void AllQuizReport()
        {
            foreach (var test in Exam.Tests.Where(t => t.GetType() == typeof(Quiz)))
            {
                this.AssignmentReport(test);
            }
        }
        public void GetExamReport(Type type, string Title = "Examination Report")
        {
            Console.WriteLine($"{Environment.NewLine}{Title} - {Exam.Title}");
            Console.WriteLine("======================================");
            foreach (var test in Exam.Tests.Where(t => t.GetType() == type))
            {
                test.Display();
                foreach (var g in test.Groups)
                {
                    g.DisplayStudents();
                }
            }
        }
    }
    public class ExamClient
    {
        //Create list of Exams 
        static List<Exam> exams = new List<Exam>()
        {
            new ExamFactory("Fall 2020"),
            new ExamFactory("Spring 2020"),
            new ExamFactory("Fall 2021")
        };
        public static void Main_ddd(string[] args)
        {
            ExamDemo();

            ReportDemo(exams.FirstOrDefault(e => e.Title == "Spring 2020"));
            ReportDemo(exams.FirstOrDefault(e => e.Title == "Fall 2020"));
            
            Console.ReadKey();
        }
        //Displays each exam, its all tests and list students that appear in each test.
        private static void ExamDemo()
        {
            var index = 1;
            foreach (var exam in exams)
            {
                Console.WriteLine("\n" + $"{index++}.  {exam.Title}  -  {exam.GetType().Name}");
                foreach (var test in exam.Tests)
                {
                    //Console.WriteLine("".PadRight(10) + $"{arrow} {test.Title}  -  {test.GetType().Name}");
                    test.Display();
                    foreach (var g in test.Groups)
                    {
                        g.DisplayStudents();
                        //Console.WriteLine("".PadRight(15) + $"{arrow}  {g.GroupTitle } - {g.Students[0].CourseTitle}");
                        //foreach (var s in g.Students)
                        //{
                        //    Console.WriteLine("".PadRight(20) + $".  { s.StudentID }, {s.FullName}");
                        //}
                    }
                }
            }

        }
        
        //Displays differnt types of exam reports
        public static void ReportDemo(Exam exam)
        {
            //Report Demo
            Console.WriteLine($"{"".PadRight(30)} {Environment.NewLine} Examination Reports");
            //Create Report
            IExamReport report = new ExamReport(exam);

            //Get test by title for a given exam
            var test = exam.GetTestByTitle("Assignment - 1");
            report.AssignmentReport(test);

            test = exam.GetTestByTitle("Quiz - 1");
            report.QuizReport(test);

            //report.AllAssignmentReport();

            report.GetExamReport(typeof(Assignment));
            report.GetExamReport(typeof(Quiz), "Quiz Examination");
        }
    }
}
