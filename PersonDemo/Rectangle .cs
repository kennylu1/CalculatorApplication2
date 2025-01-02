using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    public class Rectangle : Polygon ,I2DShape
    {
        public Rectangle(double width, double length)
        {
            Length = length;
            Width = width;
        }
        public double Length { get; set; }
        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }

        //public override string GetShapeName()
        //{
        //    return "";
        //}
    }
}