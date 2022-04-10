using Ex20._8.CustomerFolder;

namespace Ex20._8.Interfaces
{
    public interface IAccount
    {
        decimal Balance { get; set; }
        Customer Customer { get; set; }
        Individual Individual { get; set; }
        Company Company { get; set; }
        decimal InterestRate { get; set; }
    }
}
