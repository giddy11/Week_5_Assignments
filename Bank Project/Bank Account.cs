using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Project.Customers;
using Bank_Project.Interfaces;

namespace Bank_Project
{
    public abstract class Bank_Account 
    {
        public Customer_Account Customers { get; set; }
        public decimal Balance { get; set; }
        public float InterestRate { get; set; }
        public int Month { get; set; }


        public virtual double CalculateInterest()
        {
            return InterestRate * Month;
        }
        

        
    }
}
