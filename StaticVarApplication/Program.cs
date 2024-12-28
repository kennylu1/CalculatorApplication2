namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public void count()
        { num++; }//方法設定每次加1

        public int getNum()
        { return num; }

        class StaticTester
        {
            static void Main(string[] args)
            {
                StaticVar s1 = new StaticVar();
                StaticVar s2 = new StaticVar();
                s1.count();
                s1.count();
                s1.count();
                s2.count();
                s2.count();
                s2.count();
                Console.WriteLine($"s1的變量num:{s1.getNum()}");
                Console.WriteLine($"s2的變量num:{s2.getNum()}");
                Console.ReadKey();

            }
        }
    }
}
