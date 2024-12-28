namespace SomeNameSpace
{
   public class MyClass
    {
        static void Main()
        {
            Console.WriteLine("In SomeNameSpace");
            Nested.NestedNameSpaceClass.SayHello();
        }
    }


    namespace Nested
    {
        public class NestedNameSpaceClass
        {
            public static void SayHello() {

                Console.WriteLine("In Nested");
        }
            

    }
}
}