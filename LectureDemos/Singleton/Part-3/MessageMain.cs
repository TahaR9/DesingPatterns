using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sington Pattern Inheritence Scenario.
/// </summary>
namespace Patterns.Singleton.Part3
{
    class Program
    {
        static void P3Main(string[] args)
        {
            Message msg1 = Message.GetInstance();
            
            Message msg2 = Message.GetInstance();

            //Message.Derived derived = new Message.Derived();
            
            Console.ReadKey();

        }
    }
}
