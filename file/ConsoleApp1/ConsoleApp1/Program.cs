using System;

class Program
{
   static void Main()
    {
        User<int>user1= new User<int>();
        User<bool> user2 = new User<bool>();

        user1.RegistrationStatus = 1234;
        user2.RegistrationStatus =false;
        Console.WriteLine(user1.RegistrationStatus);
        Console.ReadKey();
    }

    /*Razor pages    blazor*/
}