using Ex20._8.Interfaces;
using Ex20._8.CustomerFolder;

namespace Ex20._8
{
    public class MortgageAccount : BankAccount, IDeposit
    {
        public override decimal CalculateInterestRate(int month)
        {
            if (Customer is Individual) return Balance * InterestRate * (month - 6);

            if (Customer is Company) return InterestRate * (Math.Min(month, 12) / 2 + Math.Max(month - 12, 0));

            return InterestRate * month;
        }

        public void Deposit(decimal Amount)
        {
            Balance += Amount;
        }
    }
}
