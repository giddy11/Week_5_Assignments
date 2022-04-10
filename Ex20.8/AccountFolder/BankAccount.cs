using Ex20._8.CustomerFolder;
using Ex20._8.Interfaces;

namespace Ex20._8
{
    public abstract class BankAccount : IAccount
    {
        public decimal Balance { get; set; }
        public  Customer Customer { get; set; }
        public  Individual Individual { get; set; }
        public Company Company { get; set; }
        public decimal InterestRate { get; set; }

        public virtual decimal CalculateInterestRate(int month)
        {
            return InterestRate * month;
        }

    }

    




}
