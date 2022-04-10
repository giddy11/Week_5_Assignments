using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project.Customers
{
     class Companies_Account : Customer_Account
    {
        public override double CalculateInterest()
        {
            if (Month <= 12)
            {
                return (InterestRate / 2 * Month);
                Month++;
            }

            return base.CalculateInterest();
        }
    }
}
