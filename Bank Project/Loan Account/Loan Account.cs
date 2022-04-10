using Bank_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project.Loan_Account
{
    class Loan_Account : Bank_Account, IDeposit
    {
        public void DepositMoney()
        {
            Console.WriteLine("Depositing Money");
        }

        public override double CalculateInterest()
        {
            return InterestRate * Month;
        }
    }
}
