using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternDemo1
{
    
    public class Program
    {
        public enum MessageType
        {
            SMS,
            WHATSAPP,
            EMAIL
        }

        public void SendSMS()
        {
            Console.WriteLine("Welcome to the Design Patters SMS");
        }

        public void SendWhatsApp()
        {
            Console.WriteLine("Welcome to the Design Patters Whatsapp");
        }
        public  void SendEmail()
        {
            Console.WriteLine("Welcome to the Design Patters Email");
        }

        public void SendMessage(MessageType which)
        {
            switch (which)
            {
                case MessageType.SMS:
                    Console.WriteLine("Welcome to the Design Patters SMS");
                    break;
                case MessageType.WHATSAPP:
                    Console.WriteLine("Welcome to the Design Patters Whatsapp");
                    break;
                case MessageType.EMAIL:
                    Console.WriteLine("Welcome to the Design Patters Eamil");
                    break;
            }
        }


        public void SendMessage(int which)
        {
            switch (which)
            {
                case 10:
                    Console.WriteLine("Welcome to the Design Patters SMS");
                    break;
                case 1:
                    Console.WriteLine("Welcome to the Design Patters Whatsapp");
                    break;
                case 2:
                    Console.WriteLine("Welcome to the Design Patters Eamil");
                    break;
            }
        }

        public void SendMessage(string message, MessageType which)
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
        public static void Main_001(string[] args)
        {
            Program app = new Program();
            //app.SendSMS();
            //app.SendWhatsApp();
            //app.SendEmail();

            //app.SendMessage(10);
            //app.SendMessage(1);
            //app.SendMessage(2);

            //app.SendMessage(MessageType.SMS);
            //app.SendMessage(MessageType.WHATSAPP);
            //app.SendMessage(MessageType.EMAIL);

            var message = "Today our class would start @ 1700 Hrs";
            app.SendMessage(message, MessageType.SMS);
            app.SendMessage(message, MessageType.WHATSAPP);
            app.SendMessage(message, MessageType.EMAIL);

            Console.ReadKey();
        }

    }

}
