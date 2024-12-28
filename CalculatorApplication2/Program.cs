using System;
namespace CalculatorApplication2
{
	class NumberManipulator
    {
		public int factorial(int num)//遞迴  每一次傳進來的值
		{
			int result;
			if (num == 1) 
				{
                return  1;
				}
				else
				{

					result = factorial(num-1)*num;
					return result;
				}



		}
			static void Main(string[] args)
			{
				NumberManipulator n = new NumberManipulator();/*數字需要物件*/
            Console.WriteLine($"6的階乘是:{n.factorial(1)}");//算階乘         這裡數字裡面是接成

            Console.WriteLine($"6的階乘是:{n.factorial(6)}");//算階乘         這裡數字裡面是接成
                Console.WriteLine($"7的階乘是:{n.factorial(7)}");//算階乘
            Console.WriteLine($"8的階乘是:{n.factorial(8)}");//算階乘

            Console.ReadLine();


            }
        }

}