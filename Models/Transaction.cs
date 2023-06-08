using CSharpBankAccount.Enums;

namespace CSharpBankAccount.Models
{

    internal class Transaction
    {

        #region properties

        public decimal Balance { get; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public TypeOfTransaction TransactionType { get; set; }

        #endregion

        #region constructors

        public Transaction(decimal balance, decimal amount, TypeOfTransaction type)
        {
            this.Balance = balance;
            this.Amount = amount;
            this.TransactionType = type;
            this.Date = DateTime.UtcNow;
        }

        #endregion

    }
}
