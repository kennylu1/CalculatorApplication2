﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    public class Square : Polygon
    {
        public Square(int width)
        {
            Width = width;
        }
        public override double Area()
        {
            // Math.Pow(Width, 2);
            return Width * Width;
        }
    }
}