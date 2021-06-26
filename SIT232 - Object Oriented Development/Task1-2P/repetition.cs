/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           1-2P (Repetition)
DATE:           11/07/2020
STATUS:         COMPLETED

REVISIONS:      11/07/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task1_2P
{
    class Repetition
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the upper bound (as an integer)");
            int upperbound = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            double average = 0.00;

            int i = 0;

            do
            {
                sum += i;
                i++;
            } while (i <= upperbound);

            // Display Sum
            Console.WriteLine("The Sum is: {0}", sum);

            // Calculate and Display Avg
            average = (Convert.ToDouble(sum) / Convert.ToDouble(upperbound)); 
            Console.WriteLine("The Average is: {0}", average);

            Console.WriteLine("Press any key to Exit");
            Console.ReadLine();

        }
    }
}
