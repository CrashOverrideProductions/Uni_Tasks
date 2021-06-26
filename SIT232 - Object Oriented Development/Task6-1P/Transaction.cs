/*****************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           6-1P (Transaction.cs)
DATE:           09/09/2020
STATUS:         COMPLETED

REVISIONS:      09/09/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_1P
{
    abstract class Transaction
    {
        // Instance Vars
        protected decimal _amount;
        protected Boolean _success = false;
        private Boolean _executed = false;
        private Boolean _reversed = false;
        private DateTime _dateStamp;

        // Public Property Getters
        public Decimal Amount
        {
            get
            {
                return _amount;
            }
        }

        public Boolean Success
        {
            get
            {
                return _success;
            }
        }

        public Boolean Executed
        {
            get
            {
                return _executed;
            }
        }

        public Boolean Reversed
        {
            get
            {
                return _reversed;
            }
            set
            {
                _reversed = value;
            }
        }

        public DateTime DateStamp
        {
            get
            {
                return _dateStamp;
            }
        }

        // Constructor
        public Transaction(decimal amount)
        {
            if (amount > 0)
            {
                _amount = amount;
            }
            else
            {
                amount = 0;
                throw new ArgumentOutOfRangeException("Amount must be greater than $0.00");
            }
        }

        // Get Account Name
        public virtual String GetAccountName()
        {
            return null;
        }

        public virtual String GetAccountFromName()
        {
            return null;
        }

        public virtual String GetAccountToName()
        {
            return null;
        }

        public virtual String GetTransactionType()
        {
            return null;
        }

        public virtual void Print()
        {
          
        }

        public virtual void Execute()
        {
            if (_executed && _success)
            {
                throw new InvalidOperationException("Transaction already executed");
            }
            _executed = true;
            _dateStamp = DateTime.Now;
        }

        public virtual void Rollback()
        {
            if (!_success)
            {
                throw new InvalidOperationException("Transaction Failed, Nothing to Rollback");
            }
            else if (_reversed)
            {
                throw new InvalidOperationException("Transaction already reversed");
            }
            _dateStamp = DateTime.Now;
        }


    }
}
