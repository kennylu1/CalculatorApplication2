namespace BoxApplication2
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;
        public void setLength(double len)
        { length = len; }
        public void setBreadth(double bre)
        { breadth = bre; }
        public void setHeight(double hei)
        { height = hei; }
        public double getVolume()
        { return length*breadth*length; }

        //private 需要set 跟get
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine($"Box1的體積:{volume}");
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine($"Box2的體積:{volume}");
            Console.ReadKey();

        }
    }
}
