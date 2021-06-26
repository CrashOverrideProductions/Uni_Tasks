/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           1-2P (GuessingNumber)
DATE:           11/07/2020
STATUS:         COMPLETED

REVISIONS:      11/07/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task1_2P
{
    class GuessingNumber
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Guessing Game - Guess the number between 1 and 10");

            int number = 5;

            bool correctGuess = false;

            do
            {

                try
                {
                    // Get User Input
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input >= 1 && input <= 10)
                    {
                        if (input == number)
                        {
                            correctGuess = true;
                            Console.WriteLine("You have guessed the number! Well done!");
                            Console.WriteLine("Press any key to Exit");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("{0} is not a correct guess", input);
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid input", input);
                        continue;
                    }


                }
                catch {
                Console.WriteLine("Enter the number (as an Integer)");
                continue;
                }
            } while (correctGuess == false);




        }
    }
}
