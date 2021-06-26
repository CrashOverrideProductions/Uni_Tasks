/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           2-3C (TestMyTime.cs)
DATE:           05/09/2020
STATUS:         COMPLETED

REVISIONS:      05/09/2020 - FILE CREATION
******************************************************************************/
using System;

namespace Task2_3C
{
    class TestMyTime
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            MyTime time = new MyTime(23, 59, 00);


            Console.WriteLine("Next Second Test");


            while (i < 120)
            {
                time.NextSecond();
                Console.WriteLine(time.ToString());

                i += 1;
            }


            Console.WriteLine("Previous Second Test");


            while (j < 120)
            {
                time.PreviousSecond();
                Console.WriteLine(time.ToString());

                j += 1;
            }

            Console.WriteLine("------------------------------------------------------------");
            time.SetHour(23);
            time.SetMinute(00);
            time.SetSeconds(00);

            Console.WriteLine("Set Time", time.ToString());

            i = 0;
            j = 0;

            Console.WriteLine("Next Minute Test");

            while (i < 65)
            {
                time.NextMinute();
                Console.WriteLine(time.ToString());
                i++;
            }

            Console.WriteLine("Previous Minute Test");


            while (j < 65)
            {
                time.PreviousMinute();
                Console.WriteLine(time.ToString());
                j++;
            }

            Console.ReadLine();



            Console.WriteLine("------------------------------------------------------------");
            time.SetHour(12);
            time.SetMinute(00);
            time.SetSeconds(00);

            Console.WriteLine("Set Time", time.ToString());

            i = 0;
            j = 0;

            Console.WriteLine("Next Hour Test");

            while (i < 15)
            {
                time.NextHour();
                Console.WriteLine(time.ToString());
                i++;
            }

            Console.WriteLine("Previous Hour Test");


            while (j < 15)
            {
                time.PreviousHour();
                Console.WriteLine(time.ToString());
                j++;
            }

            Console.ReadLine();
        }

    }
    
}
