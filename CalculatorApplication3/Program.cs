namespace CalculatorApplication3
{
     class NumberManipulator
    {
       public void getValue(out int x)
        {
            int temp = 10;
            x = temp;
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            Console.WriteLine($"在方法調用之前，a的值:{a}");
            n.getValue(out a);//get value啟用改變後面的a值變成10
            Console.WriteLine($"在方法調用之後，a的值:{a}");
            Console.ReadLine();


        }
    }
}
