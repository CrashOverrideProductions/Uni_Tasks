/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           2-1P (MobileProgram.cs)
DATE:           20/07/2020
STATUS:         COMPLETED

REVISIONS:      20/07/2020 - FILE CREATION
******************************************************************************/

using System;

namespace Task2_1P
{
    class MobileProgram
    {
        static void Main(string[] args)
        {
            Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");
            Mobile samMobile = new Mobile("Monthly", "iPhone", "0400123456");

            jimMobile.setAccType("PAYG");
            jimMobile.setDevice("iPhone 6S");
            jimMobile.setNumber("07713334466");
            jimMobile.setBalance(15.50);

            samMobile.setBalance(28.75);


            Console.WriteLine("Account Type: " + jimMobile.getAccType() + "\nMobile Number: " 
                + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " 
                + jimMobile.getBalance());

            Console.WriteLine("Account Type: " + samMobile.getAccType() + "\nMobile Number: " 
                + samMobile.getNumber() + "\nDevice: " + samMobile.getDevice() + "\nBalance: " 
                + samMobile.getBalance());
            Console.ReadLine();

            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);

            samMobile.addCredit(15.00);
            samMobile.makeCall(20);
            samMobile.sendText(5);

            Console.ReadLine();
        }
    }
}
