using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Factory.PartB
{
    public class FactoryClient
    {
        public static void Main_skills(string[] args)
        {
            //Document[] documents = new Document[2];
            //documents[0] = new Resume();
            //documents[1] = new Report();

            List<Document> documents = new List<Document>();
            documents.Add(new Resume());
            documents.Add(new Report());

            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "---");
                foreach(var page in document.Pages)
                {
                    Console.WriteLine("  " + page.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }
}
