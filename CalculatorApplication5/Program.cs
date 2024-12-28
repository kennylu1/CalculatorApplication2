namespace CalculatorApplication5
{
     class NullablesAtShow
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 =new double?();
            double? num4 = 3.14157;
            bool? boolval=new bool?();

            Console.WriteLine($"顯示可空類型的值:{num1},{num2},{num3},{num4}");
            Console.WriteLine($"一個可空的布林值:{boolval}");
            Console.ReadLine();
        }
    }
}
