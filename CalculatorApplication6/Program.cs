namespace CalculatorApplication6
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine($"num3的值:{num3}");
            /* num1 ?? 5.34 表示：「如果 num1 是 null，則取值 5.34；否則取 num1 的值」。
因為 num1 是 null，所以運算結果為 5.34。   */
            num3 = num2 ?? 5.34;
            Console.WriteLine($"num3的值:{num3}");
            Console.ReadLine();
            /*           num2 ?? 5.34 表示：「如果 num2 是 null，則取值 5.34；否則取 num2 的值」。
因為 num2 是 3.14157（不是 null），所以運算結果為 3.14157。*/


        }
    }
}
