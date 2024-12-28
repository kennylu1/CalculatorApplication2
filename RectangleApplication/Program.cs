using System.Drawing;

namespace RectangleApplication
{
     class Rectangle
    {
        protected double length;
        protected double width;//封裝值
        public Rectangle(double l,double w)
        {  length = l; width = w; } 

        public double GetArea()
        {
            return length*width;//定義值
        }
        public void Display() {

            Console.WriteLine($"長度:{length}");
            Console.WriteLine($"寬度:{width}");
            Console.WriteLine($"面積:{GetArea()}");

        }
        class Tabletop:Rectangle
        {
            private double cost;
            public Tabletop(double l,double w):base(l,w) {
        }
            public double GetCost()
            {
                double cost = 0;
                cost = GetArea()*70;
                return cost;
            }
            public void Display()
            {
                base.Display();
                Console.WriteLine($"成本:{GetCost()}");
            }
        }
        class ExecuteRectangle
        {

       
        static void Main(string[] args)
        {
                Tabletop t = new Tabletop(4.5, 7.5);
                t.Display();
            Console.ReadLine();
        }
    }
}
}