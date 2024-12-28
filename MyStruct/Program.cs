namespace MyStruct
{//測試樣本  無法readline
    struct MyStruct
    {
        public int X;
        public int Y;
    }
    public MyStruct(int x,int y)
        {
            X = x;
            Y = y;
        }
        class MyClass
    {
        public int X;
        public int Y;
    }

    public MyClass()
        {

        }

        public MyClass(int x,int y)
        {
            X = x;
            Y = y;
        }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct structInstance1 = new MyStruct(1,2);
            MyStruct structInstance2 = structInstance1;



        }
    }
}
