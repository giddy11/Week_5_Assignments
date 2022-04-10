using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Teachers_Students
{
     public class Student : IDetails
    {
        #region Data 
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        #endregion

        #region Functions

        public void PayFees(double amount)
        {
            if (amount == 50000) Console.WriteLine($"{FullName} has paid fully");
            else if (amount < 50000) Console.WriteLine($"{FullName} has paid in half");
            else Console.WriteLine($"Has not paid");
        }

        public void GetDetails()
        {
            Console.WriteLine($"Student: {FullName}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Age: {Age}");
        }

        #endregion
    }
}
