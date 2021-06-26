/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-1P (Pengin.cs)
DATE:           12/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_1P_WithInheritance
{

    class Penguin : Bird
    {
        public String colourStripes;

        public Penguin(String name, String diet, String location, double weight, int age,
            String colour, String species, String colourStripes) :
            base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Squabble");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 4-11 lbs of Krill, Squid and Fish");
        }

        public override void attackHuman()
        {
            Console.WriteLine("I dont attack humans unless protecting my nest");
        }

        public void layEggs()
        {
            Console.WriteLine("1-2 eggs / year");
        }

        public void fly()
        {
            Console.WriteLine("I do not fly");
        }

    }
}
