/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-1P (ZooPark.cs)
DATE:           11/08/2020
STATUS:         COMPLETED

REVISIONS:      11/08/2020 - FILE CREATION
******************************************************************************/

using System;

namespace Task4_1P_WithInheritance
{
    class ZooPark
    {
        static void Main(string[] args)
        {

            // Declare Instances
            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey", "", "");
            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black","Harpy","");
            Lion timLion = new Lion("Tim the Lion", "Meat", "Cat Land", 115, 7, "Orange", "Abyssinian", "");
            Penguin samPenguin = new Penguin("Sam the Penguin", "Krill/Crustations/Fish", "Ice Cave", 30, 10, "White and Black", "Emperor","");



            // Test WilliamWolf
            Console.WriteLine("William Wolf");
            williamWolf.eat();
            williamWolf.sleep();
            williamWolf.makeNoise();
            williamWolf.attackHuman();

            // Test Tony Tiger
            Console.WriteLine("");
            Console.WriteLine("Tony Tiger");
            tonyTiger.eat();
            tonyTiger.sleep();
            tonyTiger.makeNoise();
            tonyTiger.attackHuman();

            // Test Edgar Eagle
            Console.WriteLine("");
            Console.WriteLine("Edgar Eagle");
            edgarEagle.eat();
            edgarEagle.sleep();
            edgarEagle.makeNoise();
            edgarEagle.attackHuman();

            // Test Tim Lion
            Console.WriteLine("");
            Console.WriteLine("Tim Lion");
            timLion.eat();
            timLion.sleep();
            timLion.makeNoise();
            timLion.attackHuman();

            // Test Sam Penguin
            Console.WriteLine("");
            Console.WriteLine("Tim Lion");
            samPenguin.eat();
            samPenguin.sleep();
            samPenguin.makeNoise();
            samPenguin.attackHuman();




            Console.ReadLine();


        }
    }
}
