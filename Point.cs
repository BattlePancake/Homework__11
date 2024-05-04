using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__11
{
    //---------------------------- Task 2 -------------------------------

    public class Point
    {
        internal double x { get; }
        internal double y { get; }

        public Point(double x1, double x2)
        {
            x = x1;
            y = x2;
        }

        public void PrintCoords()
        {
            Console.WriteLine($"{x}, {y}");
        }
    }
}
