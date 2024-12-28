namespace LineApplication
{
    class Line
    {
        private double length;
        public Line()
        { Console.WriteLine("對象已創建"); }

        public void setLength(double len)
        { length = len; }
        public double getLength() { return length; }

        static void Main(string[] args)
        {
            Line line = new Line();
            line.setLength(6.0);
            Console.WriteLine($"線條的長度： {line.getLength()}");
            Console.ReadKey();
        }
    }
}
