using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

/*
 Message sending application 

*/
namespace DPDemo
{
    public class Developer4
    {
        public enum MessageType
        {
            SMS=900, WHATSAPP, EMAIL
        }
        void SendMessage(string message, MessageType which)
        {
            switch (which)
            {
                case MessageType.SMS:
                    Console.WriteLine(message);
                    break;
                case MessageType.WHATSAPP:
                    Console.WriteLine(message);
                    break;
                case MessageType.EMAIL:
                    Console.WriteLine(message);
                    break;
            }
        }

        public static void Main_004(string[] args)
        {
            Console.WriteLine("Welcome to Design Patters Course");
            Developer4 app = new Developer4();
            app.SendMessage("This is a test message", MessageType.SMS);
            app.SendMessage("Whatspp people say hello..", MessageType.WHATSAPP);
            app.SendMessage("Developer 4 has done the job better than others", MessageType.EMAIL);


            //Console.Write("Enter message : ");
            //var msg = Console.ReadLine();

            //Console.WriteLine("=============================================");
            //app.SendMessage(msg, MessageType.WHATSAPP);

            //Menu();
            Console.ReadKey();
        }


        public static void Menu()
        {
            while (true) 
            {
                Console.WriteLine("Message Application");
                Console.WriteLine("==============================");
                Console.WriteLine("1 - SMS Messsage");
                Console.WriteLine("2 - WhatsApp Messsage");
                Console.WriteLine("3 - Email Messsage");


                Console.Write("Enter choice : ");
                var x = Console.ReadLine();

                if (x == "yes")
                    break;
            }
        }
    }


}

