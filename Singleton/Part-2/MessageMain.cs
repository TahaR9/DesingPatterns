using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sington Pattern Default Scenario with other responsibilities.
/// i.e Send()
/// Multiple clients i.e Student, Faculty
/// </summary>
namespace Patterns.Singleton.Part2
{
    public class Student
    {
        public void Register()
        {
            Message m = Message.GetInstance();
            m.Send();
        }
    }
    public class Faculty
    {
        public void DoAttendance()
        {
            Message m = Message.GetInstance();
            m.Send();
        }
    }
    class Program
    {
        static void P2Main(string[] args)
        {

            Message msg1 = Message.GetInstance();
            msg1.Send();
            
            Message msg2 = Message.GetInstance();
            msg2.Send();

            Student student = new Student();
            student.Register();

            Faculty faculty = new Faculty();
            faculty.DoAttendance();

            Console.ReadKey();

        }
    }
}
