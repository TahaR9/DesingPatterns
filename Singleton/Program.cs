using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Student
    {
        public void Register()
        {
            SingtonMessage m = SingtonMessage.GetInstance();
            m.Send();
        }
    }
    public class Faculty
    {
        
        public void DoAttendance()
        {
            SingtonMessage m = SingtonMessage.GetInstance();
            m.Send();
        }
    }
    class Program
    {
        public static Student student = new Student();
        static void Main(string[] args)
        {

            SingtonMessage msg = SingtonMessage.GetInstance();
            msg.Send();
            
            SingtonMessage msg1 = SingtonMessage.GetInstance();
            msg1.Send();

            Student student = new Student();
            student.Register();

            Faculty faculty = new Faculty();
            faculty.DoAttendance();

            Console.ReadKey();

        }
    }
}
