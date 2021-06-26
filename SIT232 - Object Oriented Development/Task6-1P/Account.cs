/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           6-1P (Account.cs)
DATE:           09/09/2020
STATUS:         COMPLETED

REVISIONS:      07/08/2020 - FILE CREATION
                07/08/2020 - IMPORT FROM TASK2-2
                12/08/2020 - IMPORT FROM TASK3-2
                27/08/2020 - IMPORT FROM TASK 4-2P
                09/09/2020 - IMPORT FROM TASK 5-2P
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_1P
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
            return name;
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

        public static implicit operator List<object>(Account v)
        {
            throw new NotImplementedException();
        }
    }
}
