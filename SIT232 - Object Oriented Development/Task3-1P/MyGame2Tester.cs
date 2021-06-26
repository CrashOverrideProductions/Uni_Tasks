/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           3-1P (MyGame2Tester.cs)
DATE:           03/08/2020
STATUS:         COMPLETED

REVISIONS:      03/08/2020 - FILE CREATION
******************************************************************************/

using System;

namespace Task3_1P
{
    class MyGame2Tester
    {

        static void Main(string[] args)
        {
            MyGame2 newGame = new MyGame2(null);

            bool exit = false;

            MenuOption2 userSelection;
            do
            {
                userSelection = ReadUserOption();

                int number = Convert.ToInt32(userSelection);

                if (number == 0)
                {
                    // Test Name
                    newGame.GuessNumber();
                }
                else if (number == 1)
                {
                    // Quit Application
                    Console.WriteLine("*** Sorry to see you go (Come back again)");

                    // Print name here
                    if (newGame.GetName() == null)
                    {
                        Console.WriteLine("Before you go, No number was set");
                    }
                    else
                    {
                        Console.WriteLine("Before you go, the number was " + newGame.GetNumber());
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
        public static MenuOption2 ReadUserOption()
        {
            Console.WriteLine("1: Player 1 -- Test Name, 2: Player 2 -- Guess Name, 3: Player 2 -- Giveup (Quit)");

            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());

            return (MenuOption2)(number - 1);
        }

    }
}
