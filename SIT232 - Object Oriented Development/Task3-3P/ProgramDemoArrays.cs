/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           3-3P (ProgramDemoArrays.cs)
DATE:           07/08/2020
STATUS:         COMPLETED

REVISIONS:      07/08/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task3_3P
{
    class ProgramDemoArrays
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
                                 
            Console.ReadLine();
        }

        public static void Task1()
        {
            // Declare Array
            double[] myArray = new double[10];

            // Assign the first element
            myArray[0] = 1.0;

            // Assign the second element
            myArray[1] = 1.1;

            // Assign the remainder of the elements
            myArray[2] = 1.2;
            myArray[3] = 1.3;
            myArray[4] = 1.4;
            myArray[5] = 1.5;
            myArray[6] = 1.6;
            myArray[7] = 1.7;
            myArray[8] = 1.8;
            myArray[9] = 1.9;

            // Print array elements
            Console.WriteLine("The element at index 0 in the array is " + myArray[0]);
            Console.WriteLine("The element at index 1 in the array is " + myArray[1]);
            Console.WriteLine("The element at index 2 in the array is " + myArray[2]);
            Console.WriteLine("The element at index 3 in the array is " + myArray[3]);
            Console.WriteLine("The element at index 4 in the array is " + myArray[4]);
            Console.WriteLine("The element at index 5 in the array is " + myArray[5]);
            Console.WriteLine("The element at index 6 in the array is " + myArray[6]);
            Console.WriteLine("The element at index 7 in the array is " + myArray[7]);
            Console.WriteLine("The element at index 8 in the array is " + myArray[8]);
            Console.WriteLine("The element at index 9 in the array is " + myArray[9]);

        }

        public static void Task2()
        {
            // Declare array
            int[] myArray = new int[10];

            // Populate array
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i;
            }

            // Print array elements
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The element at position {0} in the array is {1}", i, myArray[i]);
            }
        }

        public static void Task3()
        {
            // Declare array
            int[] studentArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

            // Calculate total
            int total = 0;

            for (int i = 0; i < studentArray.Length; i++)
            {
                total = total + studentArray[i];
            }

            // output
            Console.WriteLine("The total marks for the student is: " + total);
            Console.WriteLine("This consists of {0} marks", studentArray.Length);
            Console.WriteLine("Therefore the average mark is {0}", (total / studentArray.Length));
        }

        public static void Task4()
        {
            // Declare Array
            String[] studentNames = new String[6];

            // Get Student Names 
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine("Enter Student name for positon {0}", i);
                studentNames[i] = Console.ReadLine();
            }

            // Print Array
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine("Student {0} - {1}", i, studentNames[i]);
            }
        }

        public static void Task5()
        {
            // Declare Array
            double[] highLow = new double[10];

            // Variables
            int currentSize = 0;
            double currentLargest = 0;
            double currentSmallest = 1.7976931348623157E+308; // Max value for Double
            // Get Array Values
            for (int i = 0; i < highLow.Length; i++)
            {
                Console.WriteLine("Enter Number for position {0}", i);
                highLow[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Print Array
            for (int i = 0; i < highLow.Length; i++)
            {
                Console.WriteLine("{0}:  {1}", i, highLow[i]);
            }

            // Find + Print Highest
            for (int i = 0; i < highLow.Length; i++)
            {
                if (currentLargest < highLow[i])
                {
                    currentLargest = highLow[i];
                }

            }
            Console.WriteLine("Highest Value in array: {0}", currentLargest);

            // Find + Print Lowest
            for (int i = 0; i < highLow.Length; i++)
            {
                if (currentSmallest > highLow[i])
                {
                    currentSmallest = highLow[i];
                }

            }
            Console.WriteLine("Lowest Value in array: {0}", currentSmallest);
        }

        public static void Task6()
        {
            // Declare MD Array
            int[,] myArray = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 } };

            // Print Array
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
