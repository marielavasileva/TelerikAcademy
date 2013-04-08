using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Triangle(9, 7);
            shapes[1] = new Rectangle(8, 2);
            shapes[2] = new Circle(6);

            foreach (var shape in shapes)
            {
                Console.WriteLine("The surface of {0} is {1:F2}.", shape.GetType().Name,
                    shape.CalculateSurface());
            }
        }
    }
}
