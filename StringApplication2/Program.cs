namespace StringApplication2
{
     class StringProg
    {
        static void Main(string[] args)
        {
            string str1 = "This is test";
            string str2 = "This is text";
            if (String.Compare(str1,str2)==0)
            {
                Console.WriteLine(str1 + "\nand" + str2 + "\nare equal.");

            }  //檢查兩個句子是否相同
            else
                { Console.WriteLine(str1 + "\nand" + str2 + "\nare not equal.");
            }
            Console.ReadKey();

        }
    }
}
