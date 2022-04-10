using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Transition_Era
{
    internal class ThirdT : Phone, ICall, IMessage, ICamera, IMms, IEmails,IGames
    {
        public ThirdT()
        {

        }
        public void MakeCall()
        {
            Console.WriteLine("Calling");
        }

        public void MakeVideo()
        {
            Console.WriteLine("Take Video");
        }

        public void PlayGames()
        {
            Console.WriteLine("Playing Games");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email");
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
