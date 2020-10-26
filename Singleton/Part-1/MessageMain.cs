using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sington Pattern Default Scenario 
/// </summary>
namespace Patterns.Singleton.Part1
{
    class Program
    {
        static void P1Main(string[] args)
        {

            Message msg1 = Message.GetInstance();
            Message msg2 = Message.GetInstance();
            
            Console.ReadKey();
        }
    }
}
