using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Transition_Era
{
    public class FirstT : Phone, ICall,IMessage
    {
        public void MakeCall()
        {
            Console.WriteLine("Calling");
        }

        public void SendMessage()
        {
            Console.WriteLine("Sending Message");
        }
    }
}
