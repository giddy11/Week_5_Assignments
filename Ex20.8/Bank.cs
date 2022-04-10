using Ex20._8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20._8
{
    public class Bank : IBank
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ICustomer> Customers { get; set; }
        public List<DepositAccount> DepositAccounts { get; set; }
        public List<LoanAccount> LoanAccounts { get; set; }
        public List<MortgageAccount> MortgageAccounts { get; set; }
    }
}
