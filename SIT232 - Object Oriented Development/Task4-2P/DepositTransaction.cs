/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-2P (DepositTransaction.cs)
DATE:           12/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_2P
{
    class DepositTransaction
    {
        // Variables
        Account _account;
        decimal _amount;
        bool _executed;
        bool _success;
        bool _reversed;

        public DepositTransaction(Account account, decimal amount)
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

            if (this._account.Deposit(_amount))
            {
                Console.WriteLine("Deposit of ${0} added", _amount);
                Console.WriteLine("Current Balance: $" + this._account.getBalance());
                this._success = true;
            }
            else
            {
                Console.WriteLine("Deposit ${0} must be greater than $0.00", _amount);
                this._success = false;
            }

        }

        public void Rollback()
        {
            Console.WriteLine("Deposit of ${0} reversed", _amount);
            this._account.Withdraw(_amount);
            Console.WriteLine("Current Balance: ${0}", this._account.getBalance());
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

