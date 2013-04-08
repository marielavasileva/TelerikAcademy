﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedPartII
{
    class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal heigth)
        {
            if (width <= 0 || heigth <= 0)
            {
                throw new ArgumentOutOfRangeException("Width and heigth should be bigger than zero!");
            }
            else
            {
                this.Width = width;
                this.Heigth = heigth;
            }
        }
        public override decimal CalculateSurface()
        {
            return this.Width * this.Heigth;
        }
    }
}
