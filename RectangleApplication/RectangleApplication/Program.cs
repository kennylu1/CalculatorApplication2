using System;
namespace RectangleApplication
{
    class Rectangle
    {
        private double length;
        private double width;

        public void AcceptDetails()
        {
            Console.WriteLine("請輸入長度:");
            length=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入寬度：");
            width=Convert.ToDouble(Console.ReadLine()); 

        }

      public double GetArea()
        {
return length*width;
    }
public void Display()
        {
            Console.WriteLine("長度:{0}", length);
            Console.WriteLine("寬度:{0}",width);
            Console.WriteLine("面積:{0}", GetArea());


        }

        class ExecuteRectangle
        {
            static void Main(string[]args)
            {    Rectangle r = new Rectangle();
            r.AcceptDetails();
                r.Display();
                Console.ReadLine();
        }
        }

    }
}