using OperatorOvlApplication;

namespace OperatorOvlApplication
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

        public static Box operator+(Box b,Box c)
            { Box box = new Box();
             box.length=b.length+c.length;
            box.breadth = b.breadth+c.breadth;
            box.height=b.height+c.height;
            return box;
        }/*  當執行 Box3 = Box1 + Box2; 時，以下步驟依次執行：

編譯器檢查 Box 類是否定義了 + 運算符重載。
找到 operator+ 方法，並將 Box1 和 Box2 作為參數傳入。
執行 operator+ 方法，計算新的 Box 對象。
將結果賦值給 Box3*/
}

    class Tester { 
    

static void Main(string[] args)
        {

        Box Box1 = new Box();
        Box Box2 = new Box();
        Box Box3 = new Box();
        double volume = 0.0;
        Box1.setLength(6.0);
        Box1.setHeight(5.0);
        Box1.setBreadth(7.0);

        Box2.setLength(12.0);
        Box2.setHeight(10.0);
        Box2.setBreadth(13.0);

        volume= Box1.getVolume();
        Console.WriteLine($"Box1體積:{volume}");
        volume = Box2.getVolume();
        Console.WriteLine($"Box2體積:{volume}");
        Box3 = Box1+Box2;
        volume = Box3.getVolume();
        Console.WriteLine($"Box3體積:{volume}");
        Console.ReadKey();
}
    }

}