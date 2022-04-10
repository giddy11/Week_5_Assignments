using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    internal class Man : Mammals
    {
        public void Talk()
        {
            Console.WriteLine("Talking");
        }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }
    }
}
