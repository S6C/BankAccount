using BankAccountDemo.Models;

namespace BankAccountDemo
{
    internal class Program
    {
        static BankAccount bankAccount = new BankAccount("Craig", "Chambers");

        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Craig", "Chambers");
           
            Console.WriteLine("Adding £75");
            bankAccount.addFunds(75);

            Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

            Console.WriteLine("Printing Journal");
            bankAccount.PrintJournal();
        }
    }
}