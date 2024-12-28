
namespace UserDefinedException
{
    class TestTemperature
    {

        static void Main(string[] args)
        {
            Temperature temp=new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {

                Console.WriteLine($"TempIsZeroException:{e.Message}");
            }
            Console.ReadKey();
        }
    }
}
