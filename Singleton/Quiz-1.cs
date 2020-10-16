using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Evaluation
{
    interface IAction
    {
        void Add();
        void Remove();
        void Display();
    }

    public class Course : IAction
    {
        public string Title { get; set; }
        public string Code { get; set; }
       
        //Registered sutents of the course
        public List<Student> Students { get; set; }

        ///IAction Interface Implementation
        public void Add()
        {
            //Logic of the method goes here
        }

        public void Display()
        {
            //Logic of the method goes here
        }

        public void Remove()
        {
            //Logic of the method goes here
        }
    }

    
    public class Person : IAction
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        ///IAction Interface Implementation
        public void Add()
        {
            //Logic of the method goes here
        }

        public void Display()
        {
            //Logic of the method goes here
        }

        public void Remove()
        {
            //Logic of the method goes here
        }
    }
    public class Student : Person
    {
        public string Registration { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class Faculty : Person
    {
        List<Student> VPStudents { get; set; }
        List<Student> DPStudents { get; set; }
    }

}
