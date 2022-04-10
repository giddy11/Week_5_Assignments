

namespace Ex20._8.Interfaces
{
    public interface IBank
    {
        //Name of Bank and Address and list of Customers
        string Name { get; set; }
        string Address { get; set; }
        List<ICustomer> Customers { get; set; }
    }
}
