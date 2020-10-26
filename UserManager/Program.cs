using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserManager.Security;

namespace UserManager
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = User.GetInstance();
            user.Print();

            User user2 = User.GetInstance();
            user2.Print();

            //User.FacultyUser faculty = new User.FacultyUser();

            Console.ReadKey();
        }
    }
}
