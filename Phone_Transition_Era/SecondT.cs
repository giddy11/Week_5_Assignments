using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Transition_Era
{
    internal class SecondT : Phone,ICall,IMessage,ICamera,IMms
    {
        public void MakeCall()
        {
            Console.WriteLine("Calling");
        }

        public void MakeVideo()
        {
            Console.WriteLine("Take Video");
        }

        public void SendMessage()
        {
            Console.WriteLine("Sending Message");
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS");
        }

        public void TakePicture()
        {
            Console.WriteLine("Taking Pictures");
        }
    }
}
