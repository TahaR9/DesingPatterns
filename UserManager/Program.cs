using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Security;

namespace UserManager
{
    class Program
    {
        public static void method()
        {
            User u = User.GetInstance("Aamir");
        }
        static void Main(string[] args)
        {
            User user = User.GetInstance("Raju");
            
            User user2 = User.GetInstance("Islam");
            user2.Print();

            method();

            method();
            method();
            method();
            method();

            //User.FacultyUser faculty = new User.FacultyUser();

            Console.ReadKey();
        }
    }
}
