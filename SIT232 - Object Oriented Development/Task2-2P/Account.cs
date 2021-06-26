/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           2-2P (Account.cs)
DATE:           26/07/2020
STATUS:         COMPLETED

REVISIONS:      26/07/2020 - FILE CREATION
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_2P
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

        public void printName()
        {
            Console.WriteLine(this.name);
        }

        public void Print()
        {
            Console.WriteLine("Account Holder:   " + this.name);
            Console.WriteLine("Current Balance: $" + this.balance);
        }

        public void Withdraw(decimal amount)
        {
            this.balance = this.balance - amount;
            Console.WriteLine("Funds Withdrawn, Current Balance: $" + this.balance);
        }

        public void Deposit(decimal amount)
        {
            this.balance = this.balance + amount;
            Console.WriteLine("Funds Added, Current Balance: $" + this.balance);
        }
    }
}
