using OperatorOvlApplication2;

namespace OperatorOvlApplication2
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setBreadth(double bre)
        { breadth = bre; }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height && lhs.breadth == rhs.breadth)
            {

                status = true;
            }
            return status;

        }
        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height || lhs.breadth != rhs.breadth)
            {
                status = true;


            }
            return status;

        }
        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length < rhs.length && lhs.height < rhs.height && lhs.breadth < rhs.breadth)
            {
                status = true;

            }
            return status;
        }
        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length > rhs.length && lhs.height > rhs.height && lhs.breadth > rhs.breadth)
            {
                status = true;

            }
            return status;
        }
        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.height <= rhs.height && lhs.breadth <= rhs.breadth)
            {
                status = true;

            }
            return status;
        }
        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length && lhs.height >= rhs.height && lhs.breadth >= rhs.breadth)
            {
                status = true;

            }
            return status;
        }
        public override string ToString()
        {
            return String.Format($"({length},{breadth},{height})");
        }
    }
    class Tester
    {


        static void Main(string[] args)
        {

            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            Box Box4 = new Box();
            double volume = 0.0;

            Box1.setLength(6.0);
            Box1.setHeight(5.0);
            Box1.setBreadth(7.0);

            Box2.setLength(12.0);
            Box2.setHeight(10.0);
            Box2.setBreadth(13.0);
            Console.WriteLine($"Box1:{Box1.ToString()}");
            Console.WriteLine($"Box2:{Box2.ToString()}");

            volume = Box1.getVolume();
            Console.WriteLine($"Box1體積:{volume}");
            volume = Box2.getVolume();
            Console.WriteLine($"Box2體積:{volume}");
            Box3 = Box1 + Box2;
            volume = Box3.getVolume();
            Console.WriteLine($"Box3體積:{volume}");
            if (Box1 > Box2)
                Console.WriteLine("Box1 大於 Box2");
            else
                Console.WriteLine("Box1 不大於 Box2");
            if (Box1 < Box2)
                Console.WriteLine("Box1 小於 Box2");
            else
                Console.WriteLine("Box1 不小於 Box2");
            if (Box1 >= Box2)
                Console.WriteLine("Box1 大於等於 Box2");
            else
                Console.WriteLine("Box1 不大於等於 Box2");
            if (Box1 <= Box2)
                Console.WriteLine("Box1 小於等於 Box2");
            else
                Console.WriteLine("Box1 不小於等於 Box2");
            if (Box1 != Box2)
                Console.WriteLine("Box1 不等於 Box2");
            else
                Console.WriteLine("Box1 等於 Box2");
            Box4 = Box3;
            if (Box3 == Box4)
                Console.WriteLine("Box3 等於 Box4");
            else
                Console.WriteLine("Box3 不等於 Box4");



            Console.ReadKey();
        }
    }

}
