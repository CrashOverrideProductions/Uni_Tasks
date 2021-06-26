/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-1P (Wolf.cs)
DATE:           12/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_1P_WithInheritance
{
    class Wolf : Animal
    {
        public String species;
        public String colourStripes;

        public Wolf(String name, String diet, String location, double weight, int age,
            String colour, String species, String colourStripes) :
            base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.colourStripes = colourStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("HOWL");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 10lbs of meat");
        }

        public override void attackHuman()
        {
            Console.WriteLine("Only on a Full Moon :P");
        }
    }
}
