using Bank_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project.Deposit_Account
{
    class Deposit_Account : Bank_Account, IDeposit, IWithdraw
    {
        public void DepositMoney()
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney()
        {
            throw new NotImplementedException();
        }

        public override double CalculateInterest()
        {
            if (Balance < 1000 && Balance > 0 )
            {
                return 0;
            }
            else return base.CalculateInterest();
            
        }
    }
}
