using System;
namespace TypeConversionApplication
{
    class StringConversion
    {
        static void Main(string[] args)

        {

            int i = 75;
            float f = 53.005f;

            // 定义一个双精度浮点型变量
            double d = 2345.7652;

            // 定义一个布尔型变量
            bool b = true;
            Console.WriteLine(i.ToString());

            // 将浮点型变量转换为字符串并输出
            Console.WriteLine(f.ToString());

            // 将双精度浮点型变量转换为字符串并输出
            Console.WriteLine(d.ToString());

            // 将布尔型变量转换为字符串并输出
            Console.WriteLine(b.ToString());
            Console.ReadKey();

        }

    }


}