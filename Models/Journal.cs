using CSharpBankAccount.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankAccount.Models
{
    internal class Journal
    {
        public List<Transaction> JournalEntries { get; set; }

        public Journal()
        {
                JournalEntries = new List<Transaction>();
        }

        public void AddEntry(decimal balance, decimal amount, TypeOfTransaction type)
        {
            Transaction transaction = new Transaction(balance, amount, type);   
            JournalEntries.Add(transaction);
        }

        public string printJournal()
        {
            string currentJournal = string.Empty;
            foreach (Transaction transaction in JournalEntries) {
                currentJournal += $"Type: {transaction.TransactionType}\t Amount: {transaction.Amount}\t Balance: {transaction.Balance}\n";
            }
            return currentJournal;
        }
    }
}
