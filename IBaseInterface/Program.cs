namespace IBaseInterface
{
    //interface IBaseInterface
    //{ void Method1();
    //}
    //interface IDerivedInterface:IBaseInterface
    //{ void Method2();
    //}
    class MyClass:IDerivedInterface   //my class繼承兩次
    {
        public void Method1(){

            Console.WriteLine("Method1 implementation");
        
        }
        public void Method2()
        {
            Console.WriteLine("Method2 implementation");
        }
    }
    class Program
    {
        static void Main(string[] args) {
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
        }
    }
}