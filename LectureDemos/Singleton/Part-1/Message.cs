using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Sington Pattern Default Scenario 
/// </summary>
namespace Patterns.Singleton.Part1
{
    public class Message
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
    }
   
}
