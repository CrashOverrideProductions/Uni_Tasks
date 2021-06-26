using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_1P
{
    class Penguin : Bird
    {

        public override void fly()
        {
            Console.WriteLine("Pengins can not fly");
        }

        public override string ToString()
        {
            return "A Penguin named " + name;
        }

    }
}
