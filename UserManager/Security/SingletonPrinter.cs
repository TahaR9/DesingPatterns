using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Security
{
    public interface IActions
    {
        void Print();
    }
    public sealed class User : IActions
    {
        static int Count;
        private static User Instance;
        private string UserName { get; set; }
        public static User GetInstance()
        {
            if (Instance == null)
            {
                Instance = new User();
            }
            return Instance;
        }
        public void Print()
        {
            Console.WriteLine("Sent to LPT1");
        }
        private User()
        {
            Count++;
            Console.WriteLine("Instance is created : " + Count);
        }

        //Concept of Inner Class / Nested Class
        //public class FacultyUser : User
        //{
        //}       

    }


}
