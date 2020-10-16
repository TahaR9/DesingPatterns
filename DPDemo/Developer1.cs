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
    public class Developer1
    {
        void SendSMS()
        {
            Console.WriteLine("SMS Message Sent.");
        }
        void SendWhatsApp()
        {
            Console.WriteLine("Whatsapp Message Sent.");
        }
        void SendEmail()
        {
            Console.WriteLine("Email Message Sent.");
        }

        public static void Main_001(string[] args)
        {
            //Console.WriteLine("Welcome to Design Patters Course");
            Developer1 app = new Developer1();
            app.SendSMS();
            app.SendWhatsApp();
            app.SendEmail();
            
            Console.ReadKey();
        }
    }


}

