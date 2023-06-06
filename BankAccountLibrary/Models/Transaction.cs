using BankAccountDemo.Enums;

namespace BankAccountDemo.Models
{
    public class Transaction
    {
        #region properties
        private DateTime _transactionDate;

        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; }
        }

        private BankTransactionType _typeOfTransaction;

        public BankTransactionType TypeOfTransaction
        {
            get { return _typeOfTransaction; }
            set { _typeOfTransaction = value; }
        }

        private decimal _ammountOfTransaction;

        public decimal AmmountOfTransaction
        {
            get { return _ammountOfTransaction; }
            set { _ammountOfTransaction = value; }
        }

        private decimal _balanceAtTimeOfTransaction;

        public decimal BalanceAtTimeOfTransaction
        {
            get { return _balanceAtTimeOfTransaction; }
            set { _balanceAtTimeOfTransaction = value; }
        }

        #endregion

        #region constructor
        public Transaction(BankTransactionType transactiontype, decimal ammount, decimal balance)
        {
            _transactionDate = DateTime.UtcNow;
            _typeOfTransaction = transactiontype;
            _ammountOfTransaction = ammount;
            _balanceAtTimeOfTransaction = balance;
        }
        #endregion
    }
}
