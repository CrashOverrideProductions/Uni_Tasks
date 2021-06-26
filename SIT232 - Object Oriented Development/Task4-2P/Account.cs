/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-2P (Account.cs)
DATE:           07/08/2020
STATUS:         COMPLETED

REVISIONS:      07/08/2020 - FILE CREATION
                07/08/2020 - IMPORT ACCOUNT.CS FROM TASK2-2 PROJECT
                12/08/2020 - IMPORT ACCOUNT.CS FROM TASK3-2 PROJECT
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_2P
{
    class Account
    {
        // Variables
        private String name;
        private decimal balance;


        public Account(String name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        // Methods

        public String accName()
        {
            return this.name;
        }

        public void printName()
        {
            Console.WriteLine(this.name);
        }

        public void Print()
        {
            Console.WriteLine("Account Holder:   " + this.name);
            Console.WriteLine("Current Balance: $" + this.balance);
        }

        public bool Withdraw(decimal amount)
        {
            if (this.balance < amount)
            {
                return false;
            }
            else
            {
                this.balance = this.balance - amount;
                return true;
            }
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            else
            {
                this.balance = this.balance + amount;
                return true;
            }
        }

        public decimal getBalance()
        {
            return this.balance;
        }
    }
}
