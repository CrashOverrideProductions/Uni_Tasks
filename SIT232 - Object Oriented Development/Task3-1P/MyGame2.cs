/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           3-1P (MyGame2.cs)
DATE:           03/08/2020
STATUS:         COMPLETED

REVISIONS:      03/08/2020 - FILE CREATION
******************************************************************************/

using System;

namespace Task3_1P
{
   public enum MenuOption2
   {
       GuessNumber, Quit
   }


    public class MyGame2
    {

        // Variables
        private int target;

        // Constructor
        public MyGame2()
        {
            this.target = new Random().Next(100) + 1;
        }



        // Methods | Functions

        // Get Number
        public int GetNumber()
        {
            return this.target;
        }

        // Guess Name
        public void GuessNumber(int input, int target)
        {
            if (input == target)
            {
                Console.WriteLine("You are a magician -- well done");
            }
            else
            {
                if (input > target)
                {
                    Console.WriteLine("Number is Higher than " + input);
                }
                else
                {
                    Console.WriteLine("Number is Lower than " + input);
                }
            }
        }

    }
}
