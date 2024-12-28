namespace test2
{
     class NumberManipulator
    {

        public void swap(int x, int y)
        { 
            int temp;
            temp = x;
            x = y;
            y = temp;

        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            int b = 200;
            Console.WriteLine("在交換之前，a的值:{0}", a);
            Console.WriteLine("在交換之前，b的值:{0}", b);
            n.swap(a, b);//
            Console.WriteLine("在交換之後，a的值:{0}", a);
            Console.WriteLine("在交換之後，b的值:{0}", b);
            Console.ReadLine();


        }
    }
}
