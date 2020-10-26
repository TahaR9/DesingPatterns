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
namespace Patterns.Singleton.Part4.Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Printer document1 = Printer.GetInstance();
            //document1.SetDocumentTitle("Price List of New Products");

            //Printer document2 = Printer.GetInstance();
            //document2.SetDocumentTitle("Refreshment Items of FoodX Cafe");

            //Thread thread1 = new Thread(document1.Print);
            //Thread thread2 = new Thread(document2.Print);

            //thread1.Start();
            //thread2.Start();

            Parallel.Invoke(() =>
            {
                Printer document1 = Printer.GetInstance();
                document1.SetDocumentTitle("Price List of New Products");
                document1.Print();
            }, () =>
            {
                Printer document2 = Printer.GetInstance();
                document2.SetDocumentTitle("Refreshment Items of FoodX Cafe");
                document2.Print();
            });

            Console.ReadKey();
        }
    }
}
