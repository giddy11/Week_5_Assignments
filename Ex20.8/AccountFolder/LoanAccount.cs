using Ex20._8.CustomerFolder;
using Ex20._8.Interfaces;

namespace Ex20._8
{
    public class LoanAccount : BankAccount, IDeposit
    {
        public override decimal CalculateInterestRate(int month)
        {
            if (Customer is Individual) return InterestRate * (month - 3);
            if (Customer is Company) return InterestRate * (month - 2);

            return InterestRate * month;
        }
        public void Deposit(decimal Amount)
        {
            Balance += Amount;
        }        
    }

}
