/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           2-2P (TestAccount.cs)
DATE:           26/07/2020
STATUS:         COMPLETED

REVISIONS:      26/07/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task2_2P
{
    class TestAccount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Account Class Test");

            Account timAccount = new Account("Tim", 120000);
            Account paulAccount = new Account("Paul", 184000);
            
            timAccount.Print();
                       
            timAccount.Deposit(36);
            timAccount.Print();
            timAccount.Withdraw(100000);
            timAccount.Print();
                       
            Console.ReadLine();                                
        }
    }
}
