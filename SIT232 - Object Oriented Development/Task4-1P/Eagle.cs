/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-1P (Eagle.cs)
DATE:           12/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_1P_WithInheritance
{
    class Eagle : Bird
    {
        public String colourStripes;

        public Eagle(String name, String diet, String location, double weight, int age,
            String colour, String species, String colourStripes) :
            base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Whistle");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 1lb of fish");
        }

        public override void attackHuman()
        {
            Console.WriteLine("I dont attack humans unless protecting my nest");
        }

        public void layEggs()
        {
            Console.WriteLine("1-5 eggs per season");
        }

        public void fly()
        {
            Console.WriteLine("I can fly");
        }

    }
}
