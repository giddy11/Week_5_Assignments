using Bank_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project.Mortgage_Account
{
    class Mortgage_Account : Bank_Account, IDeposit
    {
        public void DepositMoney()
        {
            throw new NotImplementedException();
        }

        public override double CalculateInterest()
        {
            return base.CalculateInterest();
        }

    }
}
