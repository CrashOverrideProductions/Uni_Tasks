/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           6-1P (DepositTransaction.cs)
DATE:           09/09/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
                26/08/2020 - IMPORT FROM TASK 4-2P
                09/09/2020 - IMPORT FROM TASK 5-2P
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_1P
{
    class DepositTransaction : Transaction
    {
        // Variables
        private Account _account;

        public Account Account
        {
            get
            {
                return _account;
            }
        }

        public DepositTransaction(Account account, decimal amount) : base(amount)
        {
            this._account = account;
            this._amount = amount;
        }

        public override void Print()
        {
            this._account.Print();
        }

        public override void Execute()
        {
            base.Execute();

            _success = _account.Deposit(_amount);
            if (_success)
            {
                Console.WriteLine(Success);

            }
            else if (!_success)
            {
                throw new InvalidOperationException("Invalid Deposit Amount");
            }

        }

        public override String GetAccountName()
        {
            return _account.accName();
        }

        public override String GetTransactionType()
        {
            return "Deposit";
        }

        public override void Rollback()
        {
            base.Rollback();
            bool complete = _account.Withdraw(_amount);
            if (!complete)
            {
                throw new InvalidOperationException("Insufficent Funds to Rollback");
            }
            base.Reversed = true;
        }
    }
}

