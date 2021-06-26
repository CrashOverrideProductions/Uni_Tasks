/******************************************************************************
 AUTHOR:         JUSTIN BLAND
 TASK:           8-1C (Main.java)
 DATE:           11/09/2020
 STATUS:         COMPLETED

 REVISIONS:      11/09/2020 - FILE CREATION
 ******************************************************************************/
package com.company;

public class Main {

    public static void main(String[] args) {
        {
            int i = 0;
            int j = 0;

            MyTime time = new MyTime(23, 59, 00);


            System.out.println("Next Second Test");


            while (i < 120)
            {
                time.NextSecond();
                System.out.println(time.ToString());

                i += 1;
            }


            System.out.println("Previous Second Test");


            while (j < 120)
            {
                time.PreviousSecond();
               System.out.println(time.ToString());

                j += 1;
            }

            System.out.println("------------------------------------------------------------");
            time.SetHour(23);
            time.SetMinute(00);
            time.SetSeconds(00);

            System.out.println("Set Time" + time.ToString());

            i = 0;
            j = 0;

            System.out.println("Next Minute Test");

            while (i < 65)
            {
                time.NextMinute();
                System.out.println(time.ToString());
                i++;
            }

            System.out.println("Previous Minute Test");


            while (j < 65)
            {
                time.PreviousMinute();
                System.out.println(time.ToString());
                j++;
            }




            System.out.println("------------------------------------------------------------");
            time.SetHour(12);
            time.SetMinute(00);
            time.SetSeconds(00);

            System.out.println("Set Time" + time.ToString());

            i = 0;
            j = 0;

            System.out.println("Next Hour Test");

            while (i < 15)
            {
                time.NextHour();
                System.out.println(time.ToString());
                i++;
            }

            System.out.println("Previous Hour Test");


            while (j < 15)
            {
                time.PreviousHour();
                System.out.println(time.ToString());
                j++;
            }



        }    }
}
