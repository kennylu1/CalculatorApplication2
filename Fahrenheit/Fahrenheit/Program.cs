using System;
public class Fahrenheit
{
    public double Degrees { get; set; }

    public Fahrenheit(double degrees)
    {
        Degrees = degrees;
    }
    public static implicit operator double(Fahrenheit f)
    { return f.Degrees; }

    public static explicit operator Fahrenheit(double d)
    { return new Fahrenheit(d); }

}

public class Program
{
    public static void Main()
    {
        Fahrenheit f = new Fahrenheit(98.6);
        Console.WriteLine("Fahrenheit object: " + f.Degrees + " degrees");

        double temp = f; // 隐式转换
        Console.WriteLine("After implicit conversion to double: " + temp + " degrees");

        Fahrenheit newF = (Fahrenheit)temp; // 显式转换
        Console.WriteLine("After explicit conversion back to Fahrenheit: " + newF.Degrees + " degrees");
    }
}