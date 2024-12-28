namespace LineApplication2
{
    class Line
    {
        private double length;
        public Line(double len)
        { Console.WriteLine($"對象已創建:length={len}");
        length = len;
        }

        public void setLength(double len)
        { length = len; }
        public double getLength() { return length; }

        static void Main(string[] args)
        {


            Line line = new Line(10.0);
            Console.WriteLine($"線條的長度： {line.getLength()}");

            line.setLength(6.0);
            Console.WriteLine($"線條的長度： {line.getLength()}");
            Console.ReadKey();
        }
    }
}
