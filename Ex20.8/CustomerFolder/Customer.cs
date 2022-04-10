using Ex20._8.Interfaces;

namespace Ex20._8.CustomerFolder
{
    public class Customer : BankAccount, ICustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Bank Bank { get; set; }
    }
}
