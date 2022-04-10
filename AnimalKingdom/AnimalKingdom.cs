using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class AnimalKingdom
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating!!!!");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping!!!");
        }
    }
}
