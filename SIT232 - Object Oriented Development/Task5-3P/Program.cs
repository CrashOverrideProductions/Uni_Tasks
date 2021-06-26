using System;

namespace Task5_3C
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Program Start
                Console.Write("Enter Test Environment Size - Default 20: ");
                int size = Convert.ToInt32(Console.ReadLine());
                
                Environment TestEnvro1 = new Environment(size, size);

                Console.WriteLine("Test Environment Created - Size: {0}, {0} Meters", size);

                Console.WriteLine("");

                Console.Write("Enter the Number of Rovers to Add - Default 2:");
                int rovers = Convert.ToInt32(Console.ReadLine());

                for (int x = 0; x < rovers ; x++)
                {
                    Console.Write("Enter Number of Batteries for Rover {0}: ", x);
                    int batt = Convert.ToInt32(Console.ReadLine());
                    TestEnvro1.AddRover(batt);
                }

                Console.Write("Number of Rovers Added: {0}", rovers);
                Console.WriteLine("");

                Console.WriteLine(TestEnvro1.GetRoverPosition(0)[0] + "," + TestEnvro1.GetRoverPosition(0)[1]);

                // Move Rover

                TestEnvro1.MoveRover(0, "Right", size);
                TestEnvro1.MoveRover(0, "Right", size);
                TestEnvro1.MoveRover(0, "Right", size);

                Console.WriteLine(TestEnvro1.GetRoverPosition(0)[0] + "," + TestEnvro1.GetRoverPosition(0)[1]);

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error: ");
                Console.ReadLine();
            }



        }
    }
}
