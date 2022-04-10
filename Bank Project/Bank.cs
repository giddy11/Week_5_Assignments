using Bank_Project.Deposit_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    public class Bank
    {
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual IList<Deposit_Account> DepositeAccounts { get; set; }
        public virtual IList<LoanAccount> LoanAccounts { get; set; }
        public virtual IList<MortgageAccount> MortgageAccounts { get; set; }

    }
}
