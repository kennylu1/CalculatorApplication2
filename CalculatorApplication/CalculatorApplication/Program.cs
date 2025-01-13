using System;
namespace CalculatorApplication
{
    class NumberManipulator
    {

        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                return result;
        }
        static void Main(String[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值:{0}", ret);
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}







