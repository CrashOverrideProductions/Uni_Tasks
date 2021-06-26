/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           3-3P (ProgramDemoLists.cs)
DATE:           07/08/2020
STATUS:         COMPLETED

REVISIONS:      07/08/2020 - FILE CREATION
******************************************************************************/

using System;
using System.Collections.Generic;

namespace Task3_3P
{
    class ProgramDemoLists
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

            Console.ReadLine();
        }



        public static void Task1()
        {
            // Declare List
            List<String> myStudentList = new List<String>();

            // Generate Random Number
            Random randomValue = new Random();
            int randomNumber = randomValue.Next(1, 12);

            // Add Items to List
            Console.WriteLine("You now need to add {0} students to your class list", randomNumber);

            for (int i = 0; i < randomNumber; i++)
            {
                Console.Write("Please enter the name of Student {0}: ", (i + 1));
                myStudentList.Add(Console.ReadLine());
                Console.WriteLine();
            }

            int listLength = myStudentList.Count;

            for (int i = 0; i < listLength; i++)
            {
                Console.WriteLine(myStudentList[i]);
            }
        }

        public static void Task2()
        {
            int[] tempArray = new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 10, 11 };
            FuncOne(tempArray);
        }

        public static void FuncOne(int[] array)
        {
            int counter = 0;

            if (array.Length > 10)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        // Even
                        counter = counter + 1;
                    }
                }
                Console.WriteLine("Number of even elements in array: {0}", counter);
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        // Odd
                        counter = counter + i;
                    }
                }
                Console.WriteLine("Sum of odd elements in array: {0}", counter);
            }

        }

        public static void Task3()
        {
            double[] TempArray = new double[5] { 1, 2, 3, 4, 5 };
            FuncTwo(TempArray);
        }

        public static void FuncTwo(double[] array)
        {
            double total = 0;
            double avg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                total = total + array[i];
            }

            avg = (total/array.Length);

            List<double> newList = new List<double>();

            for (int i = 0; i < array.Length; i++)
            {
                newList.Add(array[i] - avg);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Item: {0}: {1} | {2}", i, array[i], newList[i]);
            }

            Console.WriteLine("Average: {0}", avg);

        }

        public static void Task4()
        {
            int[,] twodArray = new int[2, 2] { { 0, 1 },{ 2, 3 }};
            FuncThree(twodArray);
        }

        public static void FuncThree(int[,] array)
        {

            List <int> TempList = new List<int>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) {
                    if (array[i,j] % 3 == 0)
                    {
                        TempList.Add(array[i,j]);
                    }
                }
            }

            int[] finalArray = new int[TempList.Count];

            for (int x = 0; x < TempList.Count; x++)
            {
                finalArray[x] = TempList[x];
            }

            for (int y = 0; y < finalArray.Length; y++)
            {
                Console.Write(finalArray[y] + ", ");
            }

        }

        public static void Task5()
        {
            int[] fourArray = new int[] {1,2,3,4,5};
            FuncFour(fourArray);
        }

        public static void FuncFour(int[] array)
        {
            int[,] table = new int[array.Length, array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    table[0, j] = array[j];
                }

                table[i, 0] = array[i]; 
            }

            for (int k = 1; k < table.GetLength(0); k++)
            {
                for (int l = 1; l < table.GetLength(1); l++)
                {
                    table[k, l] = table[0, k] * table[l,0];
                }
            }

            for (int x = 0; x < table.GetLength(0); x++)
            {
                for (int y = 0; y < table.GetLength(1); y++)
                {
                    Console.Write(table[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
