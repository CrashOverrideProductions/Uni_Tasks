/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           1-1P
DATE:           10/07/2020
STATUS:         COMPLETED

REVISIONS:      10/07/2020 - FILE CREATION
******************************************************************************/

using System;

namespace Task1_1P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello {0}, Shall we play a game?", 
                Environment.UserName); 
            Console.WriteLine("Press and key to continue");
            Console.ReadKey();
        }
    }
}
