namespace PolymorphismApplication2
{
    abstract class Shape
    {

        abstract public int area();}
        class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int a=0,int b=0)
        {
            length = a;
            width = b;
        }
        public override int area() {
            Console.WriteLine("Rectagle類的面積:");
            return (width*length);
        
        }
        class RectangleTester { 
        static void Main(string[] args)

        {
                Rectangle r = new Rectangle(10, 7);
                double a = r.area();
                Console.WriteLine($"面積:{a}");
                Console.ReadKey();
        }
    }
    }
}
