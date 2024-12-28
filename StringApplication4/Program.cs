namespace StringApplication4
{
    class StringProg
    {
        static void Main(string[] args)
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);
            Console.ReadKey();

            //找尋從第23個字開始的


        }
    }
}
