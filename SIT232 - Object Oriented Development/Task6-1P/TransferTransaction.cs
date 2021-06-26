/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           6-1P (TransferTransaction.cs)
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
    class TransferTransaction : Transaction
    {
        // Variables
        private Account _fromAccount;
        private Account _toAccount;

        public Account FromAccount
        {
            get
            {
                return _fromAccount;
            }
        } 

        public Account ToAccount
        {
            get
            {
                return _toAccount;
            }
        } 
        
        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount) : base (amount)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amount = amount;
        }

        public override void Print()
        {
            Console.WriteLine("From Account Balance");
            this._fromAccount.Print();
            Console.WriteLine("");
            Console.WriteLine("To Account Balance");
            this._toAccount.Print();
        }

        public override void Execute()
        {

            base.Execute();

            if (_fromAccount.Withdraw(_amount))
            {
                _success = _toAccount.Deposit(_amount);
                if (_success)
                {
                    Console.WriteLine(Success);

                }
                else if (!_success)
                {
                    throw new InvalidOperationException("Invalid Deposit Amount");
                }
            }
            
            else
            {
                throw new InvalidOperationException("Error Transfering Funds");
            }

        }

        public override String GetAccountFromName()
        {
            return FromAccount.accName();
        }

        public override String GetAccountToName()
        {
            return ToAccount.accName();
        }

        public override String GetTransactionType()
        {
            return "Transfer";
        }

        public override void Rollback()
        {
            base.Rollback();
            bool complete1 = _toAccount.Withdraw(_amount);
            bool complete2 = _fromAccount.Withdraw(_amount);
            if (!complete1)
            {
                throw new InvalidOperationException("Insufficent Funds in To Account to Rollback");
            }
            if (!complete2)
            {
                throw new InvalidOperationException("Error Depositing Funds");
            }
            base.Reversed = true;
        }
    }
}

