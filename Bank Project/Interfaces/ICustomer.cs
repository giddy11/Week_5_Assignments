using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project.Interfaces
{
    public interface ICustomer
    {
        //customer has a name, address and name of His/her bank
        
        string Name { get; set; }
        string Address { get; set; }
        Bank Bank { get; set; }
    }
}
