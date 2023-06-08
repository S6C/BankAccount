using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankAccount.Enums
{
    public enum TypeOfTransaction
    {
        AddFunds,
        WithdrawFunds,
        OpenAccount,
        CloseAccount,
        SuspendAccount,
        CheckBalance,
        PrintJournal
    }
}
