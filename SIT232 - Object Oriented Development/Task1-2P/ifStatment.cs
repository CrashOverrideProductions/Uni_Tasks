/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           1-2P (IfStatment)
DATE:           11/07/2020
STATUS:         COMPLETED

REVISIONS:      11/07/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task1_2P
{
    class IfStatment
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (as an Integer)");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 1)
                {
                    Console.WriteLine("One");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Two");
                }
                else if (number == 3)
                {
                    Console.WriteLine("Three");
                }
                else if (number == 4)
                {
                    Console.WriteLine("Four");
                }
                else if (number == 5)
                {
                    Console.WriteLine("Five");
                }
                else if (number == 6)
                {
                    Console.WriteLine("Six");
                }
                else if (number == 7)
                {
                    Console.WriteLine("Seven");
                }
                else if (number == 8)
                {
                    Console.WriteLine("Eight");
                }
                else if (number == 9)
                {
                    Console.WriteLine("Nine");
                }
                else {
                    Console.WriteLine("Error: Invalid Number");
                }
            }
            catch {
                Console.WriteLine("Error: Not a Number");
            }
            
            Console.ReadLine();

        }
    }
}
