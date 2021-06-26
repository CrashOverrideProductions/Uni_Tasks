/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-2P (TransferTransaction.cs)
DATE:           12/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_2P
{
    class TransferTransaction
    {
        // Variables
        Account _fromAccount;
        Account _toAccount;
        decimal _amount;
        DepositTransaction deposit;
        WithdrawTransaction withdraw;

        bool _executed;
        bool _success;
        bool _reversed;

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amount = amount;
        }

        public void Print()
        {
            Console.WriteLine("From Account Balance");
            this._fromAccount.Print();
            Console.WriteLine("");
            Console.WriteLine("To Account Balance");
            this._toAccount.Print();
        }

        public void Execute()
        {
            this._executed = true;

            if (this._fromAccount.Withdraw(_amount))
            {
                Console.WriteLine("Current Balance: ${0}", this._fromAccount.getBalance());
                if (this._toAccount.Deposit(this._amount))
                {
                    Console.Write("${0} transfered from {1} to {2}",this._amount, _fromAccount.accName(), this._toAccount.accName());

                    this._success = true;
                }
                else
                {
                    Rollback();
                    this._success = false;
                    this._success = false;
                }
            }
            else
            {
                Console.WriteLine("Unable to withdraw ${0}, from {1} insufficent funds available", this._amount, this._fromAccount);
                Console.WriteLine("Current Balance: $" + this._fromAccount.getBalance());
            }
        }

        public void Rollback()
        {
            Console.WriteLine("Withdrawl of ${0} reversed", _amount);
            this._fromAccount.Deposit(_amount);
            Console.WriteLine("Current Balance: ${0}", this._fromAccount.getBalance());
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

