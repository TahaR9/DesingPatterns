using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sington Pattern Multi-Threaded Scenario 
/// </summary>
namespace Patterns.Singleton.Part4.Problem
{
    public class Printer
    {
        private static int Count; //Store instance count
        private static Printer Instance; //Store instance object
        private string Document { get; set; } //Store Document title


        //Private Constructor, not accessible from outside 
        private Printer()
        {
            Count++;
            //Show instance count on console
            Console.WriteLine("Instance is created : " + Count);
        }

        //Get instance from outside
        public static Printer GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Printer();
            }
            return Instance;
        }
        public void Print()
        {
            Console.WriteLine("Document Printing [" + Document + "] ...");
        }
        public void SetDocumentTitle(string title)
        {
            Instance.Document = title;
        }

    }

}
