namespace MyClass2
{
    public class MyClass
    {
        [Obsolete("Don't use OldMethod,use NewMethod instead",true)]
        static void OldMethod()
        {
            Console.WriteLine("Is is the old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }
        public static void Main()
        {
            //OldMethod();
                       NewMethod(); // 改用新方法

        }
    }
}