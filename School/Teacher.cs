using School_Teachers_Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Teachers_Students
{
     class Teacher : Student, IDetails
    {
        #region Data of Teacher
        public string FullName { get; set; }
        public double Salary { get; set; }
        public string SubjectProfficiency { get; set; }

        #endregion

        #region Functions, Methods, Behaviours
       
        public void Lectures()
        {
            Console.WriteLine($"{FullName} Lectures {SubjectProfficiency}");
        }

        public void Resign()
        {
            Console.WriteLine($"{FullName} has Resigned.");     
        }

        public void GetDetails()
        {
            Console.WriteLine($"Teacher: {FullName}");
            Console.WriteLine($"Subject Profficiency: {SubjectProfficiency}.");
            Console.WriteLine($"Monthly Salary: {Salary}");
        }



        #endregion
    }
}
