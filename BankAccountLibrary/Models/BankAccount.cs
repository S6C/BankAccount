using BankAccountDemo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDemo.Models
{
    public class BankAccount
    {
        #region enums
        public enum Status
        {
            Open,
            Closed,
            Suspended
        }
        #endregion

        #region properties
        private Journal _journal;

        public Journal Journal
        {
            get { return _journal; }
            set { _journal = value; }
        }

        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
        }

        private string _clientFirstName;

        public string ClientFirstName
        {
            get { return _clientFirstName; }
            set { _clientFirstName = value; }
        }

        private string _clientSurname;

        public string ClientSurname
        {
            get { return _clientSurname; }
            set { _clientSurname = value; }
        }

        private DateOnly _accountCreatedDate;

        public DateOnly AccountCreatedDate
        {
            get { return _accountCreatedDate; }
            set { _accountCreatedDate = value; }
        }

        private Status _AccountStatus;

        public Status AccountStatus
        {
            get { return _AccountStatus; }
            set { _AccountStatus = value; }
        }

        #endregion

        #region constructors
        public BankAccount (string firstname, string surname)
        {
            this._balance = 0;
            this._AccountStatus = Status.Open;
            this._accountCreatedDate = new DateOnly();
            this._clientFirstName = firstname;
            this._clientSurname = surname;
            this._journal = new Journal();

            Transaction openAccountTransaction = new Transaction(BankTransactionType.AccountCreation, 0, 0);
            this.Journal.addJournalEntry(openAccountTransaction);
        }

        #endregion

        #region methods

        
        public decimal GetBalance()
        {
            decimal balance = this.Balance;
            Transaction currentTransaction = new Transaction(BankTransactionType.RequestBalance, 0, balance);
            this.Journal.addJournalEntry(currentTransaction);
            return Balance;
        }

        public void addFunds(decimal amount)
        {
            decimal balance = GetBalance();
            this._balance += amount;
            
            Transaction currentTransaction = new Transaction(BankTransactionType.AddFunds, amount, balance);
            this.Journal.addJournalEntry (currentTransaction);
        }

        public void deleteFunds(decimal amount)
        {
            this._balance -= amount;
            decimal balance = GetBalance();
            Transaction currentTransaction = new Transaction(BankTransactionType.DeleteFunds, amount, balance);
            this.Journal.addJournalEntry(currentTransaction) ;
        }

        public void PrintJournal()
        {
            string currentJournal = this.Journal.getJournalEntries();
            Console.WriteLine(currentJournal);
        }

        #endregion region

    }
}
