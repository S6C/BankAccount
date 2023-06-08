
using CSharpBankAccount.Enums;
using CSharpBankAccount.Models;
using System.Runtime.CompilerServices;

namespace CSharpBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Craig", "Personal", AccountType.personal);
            bankAccount.PrintBalance();
            bankAccount.AddFunds(100);
            bankAccount.WithDrawFunds(75);
            bankAccount.PrintBalance();
            bankAccount.PrintTansactionHistory();
        }
    }
}