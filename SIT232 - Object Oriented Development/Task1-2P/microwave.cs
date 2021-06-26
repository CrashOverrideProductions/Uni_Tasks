/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           1-2P (Microwave)
DATE:           11/07/2020
STATUS:         COMPLETED

REVISIONS:      11/07/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task1_2P
{
    class Microwave
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of items.");
                int numItems = Convert.ToInt32(Console.ReadLine());

                if (numItems > 3)
                {
                    Console.WriteLine("Heating more than three items " +
                        "at one time is not recomended");

                    Console.WriteLine("Press any key to Exit");
                    Console.ReadLine();

                }
                else if (numItems >= 1 && numItems <= 3)
                {
                    Console.WriteLine("Enter the single item heating time.");
                    int heatTime = Convert.ToInt32(Console.ReadLine());

                    double totalTime = PreformCalc(numItems, heatTime);

                    Console.WriteLine("Recomended Heat Time: {0}", totalTime);
                    Console.WriteLine("Press any key to Exit");
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("Invalid Number Selection");
                    Console.WriteLine("Press any key to Exit");
                    Console.ReadLine();
                }
            }
            catch {
                Console.WriteLine("Error: Not a Number");
                Console.WriteLine("Press any key to Exit");
                Console.ReadLine();
            }           
        }

        static double PreformCalc(int y, int x) {
            double calcResult = 0;

            calcResult = (x + ((x / 2) * (y - 1)));
            return calcResult;
        }
    }
}
