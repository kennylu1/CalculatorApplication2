using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    public abstract class Polygon
    {public int Width { get; set; }
        public abstract int Area();
    }
    public class Square : Polygon
    {
        public override int Area()
        {
            throw new NotImplementedException();
        }
    }
}
