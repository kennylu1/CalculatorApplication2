namespace PolymorphismApplication
{
     class Printdata
    {
        void  print(int i)
        { Console.WriteLine($"輸出整型:{i}"); }

        void print(double f)
        { Console.WriteLine($"輸出浮點型:{f}"); }


        void print(string s)
            { Console.WriteLine($"輸出字符串:{s}"); }
        static void Main(string[] args)
        {
            Printdata p = new Printdata();
            p.print(1);
            p.print(1.23);
            p.print("Hello Runoob");
            Console.ReadKey();
        
        }
    }
}
