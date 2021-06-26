/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           1-2P (SwitchStatment)
DATE:           11/07/2020
STATUS:         COMPLETED

REVISIONS:      11/07/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task1_2P
{
    class SwitchStatment
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (as an Integer)");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number) {
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    case 4: Console.WriteLine("Four"); break;
                    case 5: Console.WriteLine("Five"); break;
                    case 6: Console.WriteLine("Six"); break;
                    case 7: Console.WriteLine("Seven"); break;
                    case 8: Console.WriteLine("Eight"); break;
                    case 9: Console.WriteLine("Nine"); break;
                    default: Console.WriteLine("Number must be between 1 and 9"); break;

                }

            }
            catch {
                Console.WriteLine("Error: Not a Number");
            }

            Console.WriteLine("Press any key to Exit");
            Console.ReadLine();
        }
    }
}
