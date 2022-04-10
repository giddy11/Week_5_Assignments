using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project.Customers
{
    public abstract class Customer_Account : Bank_Account
    {
        public override double CalculateInterest()
        {
            return base.CalculateInterest();
        }


    }
}
