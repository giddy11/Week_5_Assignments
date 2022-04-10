using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Teachers_Students
{
     class School : Teacher, IDetails
    {
        public string NameOfSchool { get; set; }
        public int NumberOfStudent { get; set; }
        public int NumberOfTeachers { get; set; }

        #region Methods, Functions, Behaviours

        public void EmployTeacher(Teacher teacherName) 
        {
            NumberOfTeachers++;
            Console.WriteLine($"{teacherName.FullName} has been employed");
        }
        public void SackTeacher(Teacher teacherName)
        {
            if (NumberOfTeachers > 0)
            {
                Console.WriteLine($"{teacherName.FullName} has been sacked!!");
                NumberOfTeachers--;
            }
            else Console.WriteLine("There is no teacher to be sacked");
        }

        public void AdmitStudent(Student studentName)
        {
            NumberOfStudent++;
            Console.WriteLine($"{studentName.FullName} has beign admitted into {NameOfSchool}");
        }
        public void ExpelStudent(Student studentName)
        {
            NumberOfStudent--;
            Console.WriteLine($"{studentName.FullName} has beign expelled from {NameOfSchool}");
        }
        public void PaySalary(double salary,Teacher teacherName)
        {
            Console.WriteLine($"{teacherName.FullName} has been paid the sum of {salary} naira as Monthly salary");
        }

        public void GetDetails()
        {
            Console.WriteLine($"The name of School is {NameOfSchool}. It has a population of {NumberOfStudent} Students" +
                $". The total number of teachers are {NumberOfTeachers}.");
        }



        #endregion

    }
}
