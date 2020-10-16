using PareDox.Communication;
using System;

namespace ThirdDayDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Fully qualified name
            Message msg = new Message("Welcome to Design Patterns with Aaamir Pare");
            msg.Send();
            //Console.WriteLine("Welcome to Design Patterns with Aaamir Pare");
            Console.ReadKey();
        }
    }

}
