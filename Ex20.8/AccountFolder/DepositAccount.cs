using Ex20._8.Interfaces;

namespace Ex20._8
{
    public class DepositAccount : BankAccount, IDeposit, IWithdraw
    {
        public override decimal CalculateInterestRate(int month)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }
            return InterestRate * month;
        }

        public void Deposit(decimal Amount)
        {
            Balance += Amount;
        }

        public void Withdraw(decimal Amount)
        {
            Balance -= Amount;
        }
    }
}
