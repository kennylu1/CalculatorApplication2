namespace InheritanceApplication
{
     class Shape
    {
        public void setWidth(int w)
        { width=w; }
        public void setHeight(int h)
        { height = h; }
        protected int width;
        protected int height;}//封裝

        class Rectangle:Shape {//繼承
        public int getArea()
        {
            return (width*height);
        }}//增加方法


        class RectangleTester
    {

        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.setWidth(5);
            Rect.setHeight(7);//給值
            Console.WriteLine($"總面積:{Rect.getArea()}");//呼叫上面的方法
        }
    }
}
