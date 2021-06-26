using System;
using System.Collections.Generic;
using System.Text;


namespace Task4_2P
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
            Account TimAccount = new Account("Tim", 25000);
            Account JimAccount = new Account("Jim", 1000000);

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
                                doWithdraw(TimAccount);

                                ClearConsole("PAUSE"); break;

                            case 1:
                                // Deposit
                                ClearConsole("");
                                doDeposit(TimAccount);

                                ClearConsole("PAUSE"); break;

                            case 2:
                                ClearConsole("");
                                doTransfer(TimAccount, JimAccount);

                                ClearConsole("PAUSE"); break;

                            case 3:
                                // Print
                                ClearConsole("");
                                doPrint(TimAccount);
                                ClearConsole("PAUSE"); break;

                            case 4:
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
        public static void doDeposit(Account account)
        {
            Console.WriteLine("Enter amount to deposit");
            decimal withAmount = Convert.ToDecimal(Console.ReadLine());

            DepositTransaction deposit = new DepositTransaction(account, withAmount);
            deposit.Execute();
            //deposit.Print();
        }

        // Do Withdraw
        public static void doWithdraw(Account account)
        {
            Console.WriteLine("Enter amount to withdraw");
            decimal withAmount = Convert.ToDecimal(Console.ReadLine());

            WithdrawTransaction withdraw = new WithdrawTransaction(account, withAmount);
            withdraw.Execute();
            //withdraw.Print();
        }

        public static void doTransfer(Account toAccount, Account fromAccount)
        {
            Console.WriteLine("Enter amount to Transfer");
            decimal transAmount = Convert.ToDecimal(Console.ReadLine());

            TransferTransaction transfer = new TransferTransaction(toAccount,fromAccount, transAmount);
            transfer.Execute();
        }

        // Do Print
        public static void doPrint(Account account)
        {
            account.Print();
        }



        // Menu Option
        public static MenuOption ReadUserOption()
        {
            try
            {
                Console.WriteLine("1: Withdraw \n2: Deposit \n3: Transfer \n4: Print \n5: Quit");

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

