/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           4-1P (Animal.cs)
DATE:           11/08/2020
STATUS:         COMPLETED

REVISIONS:      11/08/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_1P_WithInheritance
{
       class Animal
    {
        // Variables
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String colour;

        public Animal(String name, String diet, String location, double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
    }

        // Methods
        // Make Noise
        public virtual void makeNoise()
        {
            Console.WriteLine("An animal makes a noise");
        }

        //Eat
        public virtual void eat()
        {
            Console.WriteLine("An animal eats");
        }

        public virtual void attackHuman()
        {
            Console.WriteLine("An animal may/maynot attack humans");
        }

        // Sleep
        public void sleep()
        {
            Console.WriteLine("ZZZ ZZZ ZZZ");
        }
    }




}
