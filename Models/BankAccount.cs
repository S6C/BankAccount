using CSharpBankAccount.Enums;

namespace CSharpBankAccount.Models
{
    internal class BankAccount
    {
        #region properties
        public string AccountHolder { get; set; }

        public string AccountDetails { get; set; }


        public AccountType Type { get; set; }

        public Journal AccountJournal { get; set; }

        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
        }

        #endregion

        #region constructors

        public BankAccount(string accountname, string accountdetails, AccountType type) { 
            this.AccountJournal = new Journal();
            CreateAccount(accountname, accountdetails, type);
        }

        #endregion

        #region methods

        private void addFundsToBalance(decimal amount)
        {
            this._balance += amount;
        }

        private void withdrawFundsFromBalance(decimal amount)
        {
            if (this.Balance - amount < 0)
            {
                throw new Exception("Not enough Funds");
            }
            else
            {
                this._balance -= amount;
            }
        }


        private void CreateAccount(string accountname, string accountdetails, AccountType type, decimal startAmount = 0)
        {
            this.AccountHolder = accountname;
            this.AccountDetails = accountdetails;
            this.Type = type;
            this._balance = 0;
            this.AccountJournal.AddEntry(this.Balance, startAmount, TypeOfTransaction.OpenAccount);
        }

        public void PrintBalance()
        {
            this.AccountJournal.AddEntry(this.Balance, 0, TypeOfTransaction.CheckBalance);
            Console.WriteLine($"Bank Account Balance: {this.Balance}");
        }

        public void AddFunds(decimal fundsToAdd)
        {
            this.addFundsToBalance(fundsToAdd);
            this.AccountJournal.AddEntry(this.Balance, fundsToAdd, TypeOfTransaction.AddFunds);
        }

        public void WithDrawFunds(decimal fundsToWithdraw)
        {
            this.withdrawFundsFromBalance(fundsToWithdraw);
            this.AccountJournal.AddEntry(this.Balance, fundsToWithdraw, TypeOfTransaction.WithdrawFunds);
        }

        public void PrintTansactionHistory()
        {
            Console.WriteLine(this.AccountJournal.printJournal());
            this.AccountJournal.AddEntry(this.Balance, 0, TypeOfTransaction.PrintJournal);
        }

        public void SuspendAccount()
        {

        }

        public void CloseAccount()
        {

        }

        #endregion
    }
}
