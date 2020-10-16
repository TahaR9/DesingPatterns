using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternDemo1
{

    public class BaseMessage
    {
        public void SendTextMessage()
        {
            Console.WriteLine("Message.....");
        }
    }

    public class Sms : BaseMessage
    {

        public void SendSmsMessage()
        {
            Console.WriteLine("Sms Message");
        }
    }

    public class WhatsApp : BaseMessage
    {
        public void SendWhatsappMessage()
        {
            Console.WriteLine("Whatsapp Message");
        }
    }
    public class Email : BaseMessage
    {
        public void SendEmailMessage()
        {
            Console.WriteLine("Email Message");
        }
    }

    public class RunDemo
    {
        public static void Main(string[] args)
        {
            //Sms sms = new Sms();
            //WhatsApp whatsapp = new WhatsApp();
            //Email email = new Email();

            //sms.SendSmsMessage();
            //whatsapp.SendWhatsappMessage();
            //email.SendEmailMessage();

            BaseMessage msg;
            msg = new Sms();
            msg.SendTextMessage();

            msg = new WhatsApp();
            msg.SendTextMessage();

            msg = new Email();
            msg.SendTextMessage();

            Console.ReadKey();
        }
    }
}