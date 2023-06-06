using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDemo.Models
{
    public class Journal
    {
        #region properties

        public List<Transaction> AccountJournal { get; set; }

        #endregion

        #region contructors
        public Journal()
		{
			AccountJournal = new List<Transaction>();
		}
        #endregion

        #region methods

        public void addJournalEntry(Transaction transaction)
        {
            AccountJournal.Add(transaction);
        }

        public string getJournalEntries()
        {
            string currentJournal = string.Empty;
            foreach (Transaction transaction in AccountJournal)
            {
                // date type amount balance
                currentJournal += $"Date: {transaction.TransactionDate.ToString("dd-MM-yy")}\tType: {transaction.TypeOfTransaction}\tAmount: {transaction.AmmountOfTransaction}\tBalance: {transaction.BalanceAtTimeOfTransaction}\n";
            }
            return currentJournal;
        }

        #endregion
    }
}
