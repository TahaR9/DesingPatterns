using System;
using System.Diagnostics;

namespace PareDox.Communication
{
    public class Message
    {
        private string TextMessage;
        public Message(string message)
        {
            TextMessage = message;
        }
        public void Send()
        {
            Console.WriteLine(TextMessage);
        }
    }

}
