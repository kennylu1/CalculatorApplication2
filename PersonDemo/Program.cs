// See https://aka.ms/new-console-template for more information
// Define a class
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public  class Person
{
    public Person()
    {

    }
    public Person(string firstName, string lastName, DateOnly dbo)
    {
        FirstName = firstName;
        LastName = lastName;
        DateofBirth = dbo;
    }

    //public Person(string firstName, string lastName, string taxNumber)
    //{
    //    FirstName = firstName;
    //    LastName = lastName;
    //    if (string.IsNullOrEmpty(taxNumber))
    //    {
    //        TaxNumber = GenerateTaxNumber();
    //    }
    //    else
    //    {
    //        TaxNumber = taxNumber;
    //    }
    //}



    // Properties/Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateofBirth { get; set; }
    //public string TaxNumber { get; private set; }

    // Field member
    private string _taxNumber;


    public void PrintFullName()
    {
        var type = GetType().Name;
        Console.WriteLine($"{type} name: {FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var first = FirstName[0];
        var lastInital= LastName[0];
        Console.WriteLine(first + " " + lastInital);
    }
    public void GenerateTaxNumber()
    {
        _taxNumber = RandomNumberGenerator.GetInt32(100000,9999999).ToString();
    }
    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public int GetAge()
    {
        var age=DateTime.Now.Year-DateofBirth.Year;
        return age;
    }
    public string GetAge(int year)
    {
        var age = DateTime.Now.Year - DateofBirth.Year;
        return age.ToString();
    }
}