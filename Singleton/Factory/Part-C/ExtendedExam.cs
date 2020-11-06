﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Groups.Factory
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string CourseTitle { get; set; }

    }
    public abstract class Group
    {
        public List<Student> Students { get; set; }
        public string GroupTitle { get; private set; }
        public Group(string title)
        {
            GroupTitle = title;
            this.AddStudents();
        }
        public virtual void AddStudents()
        {
            Students.Add(new Student() { StudentID = 1, FullName = "Aamir Pare", CourseTitle = "Design Pattern" });
            Students.Add(new Student() { StudentID = 2, FullName = "Mishal Pare", CourseTitle = "Design Pattern" });
            Students.Add(new Student() { StudentID = 3, FullName = "Sara Pare", CourseTitle = "Design Pattern" });
            Students.Add(new Student() { StudentID = 4, FullName = "Rashida Kazmi", CourseTitle = "Design Pattern" });
            Students.Add(new Student() { StudentID = 5, FullName = "Sumreena Khan", CourseTitle = "Design Pattern" });
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
            base.AddStudents();
        }
    }

    //Product for Examination  
    public abstract class Test
    {
        protected virtual List<Group> _Groups { get; set; }
        public List<Group> Groups => _Groups;
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
    public class Other : Test
    {
        public Other(string title) : base(title) { }
    }

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
        public abstract void Create();
    }
    public class ExamFactory : Exam
    {
        public ExamFactory(string title) : base(title) { }
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
    public class AssignmentFactory : ExamFactory
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
    public class QuizFactory : ExamFactory
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

    public class ExamClient
    {
        public static void Main_extended(string[] args)
        {
            List<Exam> exams = new List<Exam>()
            {
                new ExamFactory("Fall 2020"),
                new ExamFactory("Sprint 2021"),
                new ExamFactory("Fall 2021"),
                new AssignmentFactory("Fall 2020"),
                new QuizFactory("Fall 2020")
            };
            var index = 1;
            foreach (var exam in exams)
            {
                Console.WriteLine("\n" + $"{index++}.  {exam.Title}  -  {exam.GetType().Name}");
                foreach (var test in exam.Tests)
                {
                    Console.WriteLine("".PadRight(10) + $".  {test.Title}  -  {test.GetType().Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
