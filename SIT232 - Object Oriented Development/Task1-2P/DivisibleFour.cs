/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           1-2P (DivisibleFour)
DATE:           11/07/2020
STATUS:         COMPLETED

REVISIONS:      11/07/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task1_2P
{
    class DivisibleFour
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number (as an integer)");

            try
            {

                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numbers between 1 and {0} evenly " +
                    "divisible by 4 and not 5 are: ");

                int i = 1;

                do {
                    if (i % 4 == 0 && i % 5 !=0) {
                        Console.WriteLine(i);
                    }

                i = i + 1;
                } while (i <= input);

                Console.WriteLine("Press any key to Exit");
                Console.ReadLine();

            }
            catch {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Press any key to Exit");
                Console.ReadLine();
            }
        }
    }
}
