/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-2P (WithdrawTransaction.cs)
DATE:           12/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_2P
{
    class WithdrawTransaction
    {
        // Variables
        Account _account;
        decimal _amount;
        bool _executed;
        bool _success;
        bool _reversed;

        public WithdrawTransaction(Account account, decimal amount)
        {
            this._account = account;
            this._amount = amount;
        }

        public void Print()
        {
            this._account.Print();
        }

        public void Execute()
        {
            this._executed = true;

            if (this._account.Withdraw(_amount))
            {
                Console.WriteLine("${0} Withdrawn", this._amount);
                Console.WriteLine("Current Balance: ${0}", this._account.getBalance());
                this._success = true;
            }
            else
            {
                Console.WriteLine("Unable to withdraw ${0}, insufficent funds available", this._amount);
                Console.WriteLine("Current Balance: $" + this._account.getBalance());
            }
        }

        public void Rollback()
        {
            Console.WriteLine("Withdrawl of ${0} reversed", _amount);
            this._account.Deposit(_amount);
            Console.WriteLine("Current Balance: ${0}",this._account.getBalance());
            this._reversed = true;
        }

        public bool Executed()
        {
            return this._executed;
        }

        public bool Success()
        {
            return this._success;
        }

        public bool Reversed()
        {
            return this._reversed;
        }
    }
}
