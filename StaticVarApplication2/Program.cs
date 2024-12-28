namespace StaticVarApplication2
{
    class StaticVar
    {
        public static int num;
        public void count()
        { num++; }//方法設定每次加1

        public static  int getNum()
        { return num; }

        class StaticTester
        {
            static void Main(string[] args)
            {
                StaticVar s = new StaticVar();
                s.count();
                s.count();
                s.count();
                s.count();//每次加一次總數加一次

                Console.WriteLine($"變量num:{StaticVar.getNum()}");
                Console.ReadKey();

            }
        }
    }
}
