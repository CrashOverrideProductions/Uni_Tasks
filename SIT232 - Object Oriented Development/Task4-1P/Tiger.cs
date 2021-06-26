/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-1P (Tiger.cs)
DATE:           12/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_1P_WithInheritance
{
    class Tiger : Feline
    {
        public String colourStripes;

        public Tiger(String name, String diet, String location, double weight, int age,
            String colour, String species, String colourStripes) :
            base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("ROARRRRRRR");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 20lbs of meat");
        }

        public override void attackHuman()
        {
            Console.WriteLine("I generally only attack in self defence");
        }
    }
}
