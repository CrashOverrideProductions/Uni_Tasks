/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           6-1P (Bank.cs)
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
    class Bank
    {
        private List<Account> _accounts;

        private List<Transaction> _transactions;


        public List<Transaction> Transactions
        {
            get
            {
                return _transactions;
            }
        }


        public Bank()
        {
            _accounts = new List<Account>();
            _transactions = new List<Transaction>();
        }


        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public Account GetAccount(String name)
        {
            foreach (Account account in _accounts)
            {
                if (account.accName() == name)
                {
                    return account;
                }
            }
            return null;
        }

        public void ExecuteTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exception)
            {
                BankSystem.ErrorMessage(exception);
            }
        }

        public void RollbackTransaction(Transaction transaction)
        {
            try
            {
                transaction.Rollback();
            }
            catch (InvalidOperationException exception)
            {
                BankSystem.ErrorMessage(exception);
            }
        }


        public void PrintTransactionHistory()
        {

            Console.WriteLine(new String('*',118));
            Console.WriteLine("* {0,2} * {1,22} * {2,20} * {3,30} * {4,15} * {5,10} *",
                                 "#", "DateTime", "Type", "Account", "Amount", "Status");
            Console.WriteLine(new String('*', 118));


            int i = 0;
            foreach (Transaction transaction in _transactions)
            {

                // Need to Get Transaction Type and 
                string iName;
                string iStatus;
                DateTime iDateStamp = transaction.DateStamp;
                string iTransType = transaction.GetTransactionType();

                if (iTransType == "Transfer")
                {
                    iName = Convert.ToString(transaction.GetAccountToName() + ", " + transaction.GetAccountFromName());
                }
                else
                {
                    iName = transaction.GetAccountName();
                }

                decimal iAmount = transaction.Amount;

                if (transaction.Reversed)
                {
                    iStatus = "Reversed";
                }
                else if (transaction.Executed && !transaction.Success)
                {
                    iStatus = "Incomplete";
                }
                else if (transaction.Success && !transaction.Reversed)
                {
                    iStatus = "Complete";
                }
                else
                {
                    iStatus = "Error!";
                }

               

                Console.WriteLine("* {0,2} * {1,22} * {2,20} * {3,30} * {4,15} * {5,10} *",
                    i+1, iDateStamp, iTransType, iName, iAmount.ToString("C"), iStatus);

                i++;
            }
            Console.WriteLine(new String('*', 118));
        }

    }
}
