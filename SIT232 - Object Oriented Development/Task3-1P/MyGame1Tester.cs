/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           3-1P (MyGame1Tester.cs)
DATE:           03/08/2020
STATUS:         COMPLETED

REVISIONS:      03/08/2020 - FILE CREATION
******************************************************************************/

using System;


namespace Task3_1P
{



    class MyGame1Tester
    {

        static void Main(string[] args)
        {
            MyGame1 newGame = new MyGame1(null);

            bool exit = false;

            MenuOption userSelection;
            do
            {
                userSelection = ReadUserOption();

               int number = Convert.ToInt32(userSelection);

               if (number == 0)
               {
                    // Test Name
                    newGame.TestName();
               }
               else if (number == 1)
               {
                    // Guess Name
                    if (newGame.GetName() == null)
                    {
                        Console.WriteLine("No name is set");
                    }
                    else
                    {
                        Console.WriteLine("*** Guess the Name (Good Luck) ***");
                        string guess = Console.ReadLine();
                        newGame.GuessName(guess, newGame.GetName());
                    }

               }
               else if (number == 2)
               {
                    // Quit Application
                    Console.WriteLine("*** Sorry to see you go (Come back again)");

                    // Print name here
                    if (newGame.GetName() == null)
                    {
                        Console.WriteLine("Before you go, No name was set");
                    }
                    else
                    {
                        Console.WriteLine("Before you go, the acutal name was " + newGame.GetName());
                    }

                    exit = true;
                    Console.ReadLine();
               }
               else
               {
                    Console.WriteLine("Invalid Response -- Try Again");
               }

            }
            while (exit == false);
        }


        // Menu Option
        public static MenuOption ReadUserOption()
        {
            Console.WriteLine("1: Player 1 -- Test Name, 2: Player 2 -- Guess Name, 3: Player 2 -- Giveup (Quit)");

            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());

            return (MenuOption)(number - 1);
        }

    }
}
