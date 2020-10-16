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
        bool Add();
        bool Remove();
        bool Edit();
        void Print();
    }
    public sealed class User : IActions
    {
        static int Count;
        private static User Instance;
        private string UserName { get; set; }

        //public static User GetInstance(string name)
        //{
        //    if (Instance != null)
        //    {
        //        Instance.UserName = name;
        //        return Instance;
        //    }
        //    else
        //    {
        //        Instance = new User();
        //        Instance.UserName = name;
        //        return Instance;
        //    }
        //}

        public static User GetInstance(string name)
        {
            if (Instance == null)
            {
                Instance = new User();
                Instance.UserName = name;
            }
            return Instance;
        }

        public bool Add()
        {
            Console.WriteLine("");
            return true;
        }

        public bool Remove()
        {
            Console.WriteLine("Removed.." + Count);
            return true;
        }

        public bool Edit()
        {
            Console.WriteLine("");
            return true;
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
