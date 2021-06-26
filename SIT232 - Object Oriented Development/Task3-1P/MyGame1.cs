/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           3-1P (MyGame1.cs)
DATE:           03/08/2020
STATUS:         COMPLETED

REVISIONS:      03/08/2020 - FILE CREATION
******************************************************************************/

using System;

namespace Task3_1P
{
    public enum MenuOption
    {
        TestName, GuessThatNumber, Quit
    }


    public class MyGame1
    {

        // Variables
        private String Secret;

        // Constructor
        public MyGame1(String Secret)
        {
            this.Secret = Secret;
        }



        // Methods | Functions

        // Test Name
        public void TestName()
        {
            Console.WriteLine("*** Tell me a name (I can keet a secret) ***");
            this.Secret = Console.ReadLine();
        }

        // Get Name
        public String GetName()
        {
            return this.Secret;
        }

        // Guess Name
        public void GuessName(string input_name, string secret_name)
        {
            if (input_name.ToLower() == secret_name.ToLower())
            {
                Console.WriteLine("You are a magician -- well done");
            }
            else
            {
                Console.WriteLine("Sorry -- you guessed wrong");
            }
        }

    }
}
