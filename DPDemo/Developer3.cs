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
    public class Developer3
    {
        public enum MessageType
        {
            SMS, WHATSAPP, EMAIL
        }
        void SendMessage(MessageType which)
        {
            switch (which)
            {
                case MessageType.SMS:
                    Console.WriteLine("SMS Message Sent.");
                    break;
                case MessageType.WHATSAPP:
                    Console.WriteLine("Whatsapp Message Sent.");
                    break;
                case MessageType.EMAIL:
                    Console.WriteLine("Email Message Sent.");
                    break;

            }
        }

        public static void Main_003(string[] args)
        {
            //Console.WriteLine("Welcome to Design Patters Course");
            Developer3 app = new Developer3();
            app.SendMessage(MessageType.SMS);
            app.SendMessage(MessageType.WHATSAPP);
            app.SendMessage(MessageType.EMAIL);
            Console.ReadKey();
        }
    }


}

