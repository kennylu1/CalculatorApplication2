using System;
using System.Linq;


int number = 42;
string message = "The answer to life, the universe, and everything is";

Console.WriteLine(message + " " + number + ".");


int Add (int a,int b)=>a+b;
Console.WriteLine($"Sum of 1 and 2 is {Add(1,2)}");


var numbers = new[] { 1, 2, 3, 4, 5 };
var evens = numbers.Where(x => x%2 == 0).ToArray(); 
Console.WriteLine("Even numbers: " +string.Join(", ", evens));

try
{
    int zero = 0;
    int numberw = 9; // 假設 number 是 10
    int result;

    if (zero == 9)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    else
    {
        result = numberw / zero;
        Console.WriteLine("Result: " + result);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Unexpected error: " + ex.Message);
}