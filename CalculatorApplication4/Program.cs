namespace CalculatorApplication4
{
    class NumberManipulator
    {
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("請輸入第一個值:");

            x = Convert.ToInt32(Console.ReadLine());//自己輸入值   Convert.ToInt32  轉換成數字用

            Console.WriteLine("請輸入第二個值:");

            y = Convert.ToInt32(Console.ReadLine());


        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b;
            n.getValues(out a, out b);
            Console.WriteLine($"在方法調用之後,a的值:{a}");
            Console.WriteLine($"在方法調用之後,b的值:{b}");
            Console.ReadLine();


        }
    }
}
