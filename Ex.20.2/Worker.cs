using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._20._2
{
     class Worker : Human
    {
        public Worker()
        {

        }
        public Worker(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public double Wage { get; set; }
        public int HoursWorked { get; set; }

        public double CalculateHourlyWage(double wage, int hours)
        {
            Wage = wage;
            HoursWorked = hours;
            return Wage / HoursWorked;
        }

    }
}
