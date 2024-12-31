// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Please enter the first number:");
int num1=Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number:");
int num2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please select an operation");
Console.WriteLine("1.Addition");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Divsion");
int choice=Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine($"Result: {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"Result: {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"Result: {num1 * num2}");
        break;
    case 4:
        if (num2 != 0)
            Console.WriteLine($"Result: {num1 / num2}");
        else
            Console.WriteLine("Error: Division by zero is not allowed.");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}