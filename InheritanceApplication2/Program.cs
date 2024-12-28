namespace InheritanceApplication2
{
    class Shape
    {
        public void setWidth(int w)
        { width = w; }

        public void setHeight(int h)
        { height = h; }

        protected int width;
        protected int height;
    }

    public interface PaintCost
    { int getCost(int area); }


    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {

            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }

        class RecTangTester
        {

            static void Main(string[] args)
            {
                Rectangle Rect = new Rectangle();
                int area;
                Rect.setWidth(5);
                Rect.setHeight(7);
                area = Rect.getArea();
                Console.WriteLine($"總面積:{Rect.getArea()}");
                Console.WriteLine($"總油漆成本:{Rect.getCost(area)}");
                Console.ReadKey();





            }
        }
    }
}