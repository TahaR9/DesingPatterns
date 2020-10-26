using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Sington Pattern Inheritance Scenario.
/// The derived nested class can voilate the Singleton Pattern 
/// </summary>
namespace Patterns.Singleton.Part3
{
    /*
     * Inheritence must be sealed, means that no inheritability of the class.
     * public sealed class Message
     * sealed keyword before class makes the class un-inheritable
    */
    public sealed class Message
    {
        private static Message Instance;
        private static int Count;
        private Message()
        {
            Count++;
            Console.WriteLine("Total [" + Count + "] instance(s) exist.");
        }
        public static Message GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Message();
            }
            return Instance;
        }
        
        //sealed keyword will not allow the following 
        /*
             public class Derived : Message
             {

             }
        */

    }
   
}
