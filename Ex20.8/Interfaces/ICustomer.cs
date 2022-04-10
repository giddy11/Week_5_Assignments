

namespace Ex20._8.Interfaces
{
    public interface ICustomer
    {
        //Customer Details and Name of Bank
        string Name { get; set; }
        string Address { get; set; }
        Bank Bank { get; set; }
    }
}
