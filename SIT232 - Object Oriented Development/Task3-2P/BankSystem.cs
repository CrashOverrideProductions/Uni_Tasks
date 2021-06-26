/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           3-2P (BankSystem.cs)
DATE:           07/08/2020
STATUS:         COMPLETED

REVISIONS:      07/08/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task3_2P
{
    public enum MenuOption
    {
        Withdraw, Deposit, Print, Quit
    }

    class BankSystem
    {
        private Account TimAccount = new Account("Tim", 100);


        public void Main(string[] args)
        {
            // Define Accounts

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
                                // Withdraw
                                ClearConsole("");
                                Console.WriteLine("Enter amount to withdraw");
                                decimal withamount = Convert.ToInt32(Console.ReadLine());

                                doWithdraw(TimAccount, withamount);

                                ClearConsole("PAUSE"); break;

                            case 1:
                                // Deposit
                                ClearConsole("");
                                Console.WriteLine("Enter amount to deposit");
                                decimal depamount = Convert.ToInt32(Console.ReadLine());

                                doDeposit(TimAccount, depamount);

                                ClearConsole("PAUSE"); break;

                            case 2:
                                // Print
                                ClearConsole("");
                                doPrint(TimAccount);
                                ClearConsole("PAUSE"); break;

                            case 3:
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


        // Do Deposit
        public void doDeposit(Account account, decimal depamount)
        {
            if (TimAccount.Deposit(depamount))
            {
                Console.WriteLine("Deposit of ${0} added", depamount);
                Console.WriteLine("Current Balance: $" + account.getBalance());
            }
            else
            {
                Console.WriteLine("Deposit ${0} must be greater than $0.00", depamount);
            }
        }

        // Do Withdraw
        public void doWithdraw(Account account, decimal withamount)
        {
            if (TimAccount.Withdraw(withamount))
            {
                Console.WriteLine("${0} Withdrawn", withamount);
                Console.WriteLine("Current Balance: ${0}", account.getBalance());
            }
            else
            {
                Console.WriteLine("Unable to withdraw ${0}, insufficent funds available", withamount);
                Console.WriteLine("Current Balance: $" + account.getBalance());
            }
        }

        // Do Print
        public void doPrint(Account account)
        {
            account.Print();
        }



        // Menu Option
        public static MenuOption ReadUserOption()
        {
            try
            {
                Console.WriteLine("1: Withdraw \n2: Deposit \n3: Print \n4: Quit");

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
        public static void ClearConsole (String Message)
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
