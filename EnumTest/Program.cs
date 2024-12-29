namespace EnumTest
{
    public class EnumTest
    {
        enum Day { Sun,Mon,Tue,Wed,Thu,Fri,Sat};

        static void Main(string[] args)
        {
            /*-*/
            int t = 7;
            /*-*/
            int r = 6;
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine($"Sun={x}");
            Console.WriteLine($"Fri={y}");
              }
    }
}
