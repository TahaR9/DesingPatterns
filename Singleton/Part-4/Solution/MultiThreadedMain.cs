using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Sington Pattern Multi-Threaded Scenario 
/// </summary>
namespace Patterns.Singleton.Part4.Solution
{
    public class Program
    {
        static void Main_Solution(string[] args)
        {
            Printer document1 = Printer.GetInstance();
            document1.SetDocumentTitle("Price List of New Products");
            Thread thread1 = new Thread(document1.Print);

            Thread Thread2 = new Thread(() =>
            {
                Printer document2 = Printer.GetInstance();
                document2.SetDocumentTitle("Refreshment Items of FoodX Cafe");
                document2.Print();
            });
            thread1.Start();
            Thread2.Start();
            Console.ReadKey();
        }
    }
}
