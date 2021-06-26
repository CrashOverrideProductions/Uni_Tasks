/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           6-1P (WithdrawTransaction.cs)
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
    class WithdrawTransaction : Transaction
    {
        // Variables
        private Account _account;
       
        public Account Account { get => _account; }


        public WithdrawTransaction(Account account, decimal amount) : base(amount)
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

            _success = _account.Withdraw(_amount);
            Console.WriteLine(Success);

           // if (_success)
            //{
              //  Console.WriteLine(Success);
               // Console.WriteLine("${0} Withdrawn", _amount);
             //   Console.WriteLine("Current Balance: ${0}", _account.getBalance());
           // }
            //else
           // {
           //     throw new InvalidOperationException("Invalid Withdraw Amount");
         //   }
        }

        public override void Rollback()
        {
            base.Rollback();
            bool complete = _account.Deposit(_amount);
            if (!complete)
            {
                throw new InvalidOperationException("Insufficent Funds to Rollback");
            }
            base.Reversed = true;
        }

        public override String GetAccountName()
        {
            return _account.accName();
        }

        public override String GetTransactionType()
        {
            return "Withdraw";
        }

    }
}
