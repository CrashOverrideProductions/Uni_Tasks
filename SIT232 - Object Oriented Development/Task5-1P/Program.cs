using System;
using System.Collections.Generic;

namespace Task5_1P
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Bird> birds = new List<Bird>();

            Bird bird1 = new Bird();
            Bird bird2 = new Bird();

            bird1.name = "Feathers";
            bird2.name = "Polly";

            Penguin penguin1 = new Penguin();
            Penguin penguin2 = new Penguin();

            penguin1.name = "Happy Feet";
            penguin2.name = "Gloria";

            Console.WriteLine(penguin1.ToString());

            Console.WriteLine(penguin2.ToString());

            Duck duck1 = new Duck();
            Duck duck2 = new Duck();

            duck1.name = "Daffy";
            duck1.size = 15;
            duck1.kind = "Mallard";

            duck2.name = "Donnald";
            duck2.size = 20;
            duck2.kind = "Decoy";

            birds.Add(bird1);
            birds.Add(bird2);
            birds.Add(penguin1);
            birds.Add(penguin2);
            birds.Add(duck1);
            birds.Add(duck2);


            birds.Add(new Bird {name = "Birdy"});

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }




            List<Duck> ducksToAdd = new List<Duck>()
            {
                duck1,
                duck2,
            };

            IEnumerable<Bird> upcastDucks = ducksToAdd;

           // List<Bird> birds = new List<Bird>;
            birds.Add(new Bird() { name = "Feather" });

            birds.AddRange(upcastDucks);

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }


            Console.ReadLine();
        }
    }
}
