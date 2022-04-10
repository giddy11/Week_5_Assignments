// See https://aka.ms/new-console-template for more information
using Ex20._8;
using Ex20._8.CustomerFolder;
using Ex20._8.Interfaces;

//Bank name and address
Bank bank = new Bank() { Name = "Access Bank", Address = "Rumuola, PortHarcourt" };

// The details for - customer as an individual 
Individual customerAsIndividual = new Individual() { Name = "Gideon", Address = "Port Harcourt", Bank = bank };

// The details for - customer as a company
Company customerAsCompany = new Company() { Name = "Daniel Limited", Address = "Rivers", Bank = bank };

//Different accounts for customers
DepositAccount account1 = new DepositAccount() { Balance = 420000.00M, Individual = customerAsIndividual, InterestRate = 20 };
LoanAccount accountA = new LoanAccount() { Balance = 72000000.00M, Company = customerAsCompany, InterestRate = 50 };
MortgageAccount accountB = new MortgageAccount() { Balance = 54000000.00M, Company = customerAsCompany, InterestRate = 50 };

//List of customers
List<Customer> customers = new List<Customer>() { customerAsIndividual, customerAsCompany };

//List of accounts for acount1 and accountA
List<BankAccount> accounts = new List<BankAccount> { account1, accountA };




Console.WriteLine(account1.Balance);
customerAsIndividual.CalculateInterestRate(8);
