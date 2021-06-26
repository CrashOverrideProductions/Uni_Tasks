/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-1P (Feline.cs)
DATE:           12/08/2020
STATUS:         COMPLETED

REVISIONS:      12/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_1P_WithInheritance
{
    class Feline : Animal
    {
        private String species;

        public Feline(String name, String diet, String location, double weight, int age,
            String colour, String species) : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }

    }
}
