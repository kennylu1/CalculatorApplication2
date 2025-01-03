// See https://aka.ms/new-console-template for more information

using PersonDemo.Classes;

Console.WriteLine("************* - Classes and Objects - *************");

/* Define an object of type Person. this will be null by default. Without the new instance, it will give a null exception if it is used.
*/
Person person;
// person = new Person(); // Can be initialized at another point of the code. 

// It is best to define and declare a new object. 
Person baby = new Person();

// Using the . operator, we can access public properties and methods.
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateofBirth = new DateOnly(2023, 10, 29);
baby.PrintFullName();
baby.GenerateTaxNumber();
var taxNumber = baby.GetTaxNumber();
baby.PrintInitials();
Console.WriteLine(taxNumber);

Student student = new Student();
student.FirstName = "keny";
student.LastName = "tom";
student.DateofBirth = new DateOnly(2020, 10, 18);

student.PrintFullName();
student.GenerateTaxNumber();
student.PrintInitials();
student.GenerateStudentIdNumber();
var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);