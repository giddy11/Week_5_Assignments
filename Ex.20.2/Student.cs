using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._20._2
{
     class Student : Human
    {
        
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int GetMark(int mark)
        {
            Mark = mark;
            return Mark;
        }
        public int Mark { get; set; }
    }
}
