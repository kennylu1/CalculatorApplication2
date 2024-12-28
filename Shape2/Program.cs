namespace Shape2
{
    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("執行基類的畫圈任務");
        }
    }
    public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("畫一個圓形");
                base.Draw();
            }
        }
    public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("畫一個長方形");
                base.Draw();
            }


        }
    public class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("畫一個三角形");
                base.Draw();
            }
        }
     class Program
        {



            static void Main(string[] args)
            {
            var shapes = new List<Shape>
                {
                    new Rectangle(),
                    new Triangle(),
                    new Circle()
                }; 
                foreach (var shape in shapes)
                {
                    shape.Draw();
                }


                Console.WriteLine("按下任意鍵退出");
                Console.ReadKey();
            }
        }
    }

