using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingtonMessage
    {
        private static SingtonMessage Instance;
        private static int Count;
        private SingtonMessage()
        {
             Count++;
        }
        public static SingtonMessage GetInstance()
        {
            if (Instance != null)
            {
                return Instance;
            }
            else
            {
                Instance = new SingtonMessage();
                return Instance;
            }
        }
        public void Send()
        {
            Console.WriteLine("Message is sent : "  + Count);
        }

    }
    


}
