#define DEBUG
using System;
using System.Diagnostics;


namespace Myclass
{
    public class Myclass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Test
    {
        static void function1()
        {
            Myclass.Message("In Function1");
            function2();
        }
        static void function2()
        {
            Myclass.Message("In Function2.");
        }

        public static void Main()
        {
            Myclass.Message("In Main function.");
            function1();
            Console.ReadKey();


        }

    }
}