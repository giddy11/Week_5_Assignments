using Ex_20._1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_20._1
{
     public class Courses : IName
    {
        public int NumberOflessons { get; set; }
        public int NumberOfExercises { get; set; }
        public string Name { get; set; }
    }
}
