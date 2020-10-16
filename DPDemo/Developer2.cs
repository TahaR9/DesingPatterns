using System;

/*
 Message sending application 

*/
namespace DPDemo
{
    public class Developer2
    {
        void SendMessage(int which)
        {
            switch (which)
            {
                case 0:
                    Console.WriteLine("SMS Message Sent.");
                    break;
                case 1:
                    Console.WriteLine("Whatsapp Message Sent.");
                    break;
                case 2:
                    Console.WriteLine("Email Message Sent.");
                    break;

            }
        }

        public static void Main_002(string[] args)
        {
            //Console.WriteLine("Welcome to Design Patters Course");
            Developer2 app = new Developer2();
            app.SendMessage(0);
            app.SendMessage(1);
            app.SendMessage(2);
            Console.ReadKey();
        }
    }


}

