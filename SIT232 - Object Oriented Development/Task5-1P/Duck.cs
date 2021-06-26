using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_1P
{
    class Duck : Bird
    {
        public double size { get; set; }
        public String kind { get; set; }

        public override string ToString()
        {
            return "A Duck named " + base.name + " is a " + size + " inch " + kind;
        }
    }
}
