/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           5-2P (BankSystem.cs)
DATE:           26/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
                26/08/2020 - IMPORT FROM TASK 4-2P
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;


namespace Task5_2P
{
    public enum MenuOption
    {
        Withdraw, Deposit, Print, Quit
    }

    class BankSystem
    {
        public static void Main(string[] args)
        {

            // Define Accounts
            //Account TimAccount = new Account("Tim", 25000);
            //Account JimAccount = new Account("Jim", 1000000);

            Bank bank = new Bank();

            bool menu_exit = false;

            try
            {



                MenuOption userSelection;
                do
                {

                    userSelection = ReadUserOption();

                    try
                    {

                        int number = Convert.ToInt32(userSelection);

                        switch (number)
                        {
                            case 0:
                                // Add Account
                                ClearConsole("");
                                addAccount(bank);
                                ClearConsole("PAUSE"); break;

                            case 1:
                                // Withdraw
                                ClearConsole("");
                                doWithdraw(bank);

                                ClearConsole("PAUSE"); break;

                            case 2:
                                // Deposit
                                ClearConsole("");
                                doDeposit(bank);

                                ClearConsole("PAUSE"); break;

                            case 3:
                                ClearConsole("");
                                doTransfer(bank);

                                ClearConsole("PAUSE"); break;

                            case 4:
                                // Print
                                ClearConsole("");
                                doPrint(bank);
                                ClearConsole("PAUSE"); break;

                            case 5:
                                // Quit Application
                                menu_exit = true;
                                ExitProgram(); break;

                            default:
                                // Catch All Others Here
                                ClearConsole("Invalid Response - Please Try Again");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        CatchException(ex.ToString());
                        continue;
                    }

                }
                while (menu_exit == false);
            }
            catch (Exception ex)
            {
                CatchException(ex.ToString());
            }
        }


        // Add New Account
        public static void addAccount(Bank bank)
        {
            String name;
            decimal balance;

            Console.WriteLine("Name of New Account");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Starting Balance for {0}'s new Account", name);
            balance = Convert.ToDecimal(Console.ReadLine());

            // Add Account
            bank.AddAccount(new Account(name, balance));
        }

        // Find Account
        private static Account FindAccount(Bank bank)
        {
            Account account;
            Console.WriteLine("Enter account name:");
            string name = Convert.ToString(Console.ReadLine());

            account = bank.GetAccount(name);

            if (account == null)
            {
                Console.WriteLine("No Account found for: {0}", name);
            }
            return account;

        }

        // Do Deposit
        public static void doDeposit(Bank bank)
        {
            Account account = FindAccount(bank);

            if (account != null)
            {
                Console.WriteLine("Enter amount to deposit");
                decimal withAmount = Convert.ToDecimal(Console.ReadLine());

                DepositTransaction deposit = new DepositTransaction(account, withAmount);
                deposit.Execute();
                bank.ExecuteTransaction(deposit);
            }           
        }

        // Do Withdraw
        public static void doWithdraw(Bank bank)
        {
            Account account = FindAccount(bank);

            if (account != null)
            {
                Console.WriteLine("Enter amount to withdraw");
                decimal withAmount = Convert.ToDecimal(Console.ReadLine());

                WithdrawTransaction withdraw = new WithdrawTransaction(account, withAmount);
                withdraw.Execute();
                bank.ExecuteTransaction(withdraw);
            }
        }

        public static void doTransfer(Bank bank)
        {
            Account toAccount = FindAccount(bank);

            if (toAccount != null)
            {
                Account fromAccount = FindAccount(bank);

                if (fromAccount != null)
                {
                    Console.WriteLine("Enter amount to Transfer from {0} to {1}", fromAccount.accName(), toAccount.accName());
                    decimal transAmount = Convert.ToDecimal(Console.ReadLine());

                    TransferTransaction transfer = new TransferTransaction(toAccount, fromAccount, transAmount);
                    transfer.Execute();
                    bank.ExecuteTransaction(transfer);
                }
            }
        }

        // Do Print
        public static void doPrint(Bank bank)
        {
            Account account = FindAccount(bank);

            if (account != null)
            {
                account.Print();
            }
        }


        // Menu Option
        public static MenuOption ReadUserOption()
        {
            try
            {
                Console.WriteLine("1: Add Account \n2: Withdraw \n3: Deposit \n4: Transfer \n5: Print \n6: Quit");

                int number = 0;
                number = Convert.ToInt32(Console.ReadLine());

                return (MenuOption)(number - 1);
            }
            catch (Exception ex)
            {
                CatchException(ex.ToString());
                // exit (so that function returns a value for all code paths
                return (MenuOption)(10 - 1);
            }
        }

        // Error Handling 
        public static void CatchException(String e)
        {
            Console.WriteLine(e);
            ClearConsole("PAUSE");
        }

        // Quit Application
        public static void ExitProgram()
        {
            Console.WriteLine("\n--- Press any key to EXIT ---");
            Console.ReadLine();
        }

        // Clear Console + Pass Message (if needed)
        public static void ClearConsole(String Message)
        {
            if (Message == "")
            {
                Console.Clear();
            }
            else if (Message == "PAUSE")
            {
                Console.WriteLine("\nPress any key to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(Message);
            }
        }
    }
}

