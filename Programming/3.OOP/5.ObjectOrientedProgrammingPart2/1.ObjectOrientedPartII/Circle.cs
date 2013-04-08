using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedPartII
{
    class Circle : Shape
    {
        public Circle(decimal radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius should be positive number!");
            }
            else
            {
                this.Width = radius;
                this.Heigth = radius;
            }

        }

        public override decimal CalculateSurface()
        {
            return this.Width * this.Width * (decimal)Math.PI;
        }
    }
}
