using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_1P
{
    class Bird
    {

        public String name { get; set; }

        public Bird()
        {

        }

        public virtual void fly()
        {
            Console.WriteLine("Flap, Flap, Flap");
        }

        public override String ToString()
        {
            return "A bird called " + name;
        }
    }
}
