/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           5-2P (Bank.cs)
DATE:           26/08/2020
STATUS:         COMPLETED

REVISIONS:      26/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_2P
{
    class Bank
    {
        private List<Account> _accounts;


        public Bank()
        {
            _accounts = new List<Account>();
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

        public void ExecuteTransaction(DepositTransaction transaction) { }
        public void ExecuteTransaction(WithdrawTransaction transaction) { }
        public void ExecuteTransaction(TransferTransaction transaction) { }

       
    }
}
