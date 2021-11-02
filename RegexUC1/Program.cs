using System;

namespace RegexUC1
{
    class Program
    {
       public static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
           RegxPattern registration = new RegxPattern();
            registration.FirstName();

            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("\n Please enter  First Name--");
            string firstName = Console.ReadLine();
            RegxPattern.FirstName(firstName);                                          //taking user input and passing it in first name method of regular exp class
            Console.ReadLine();
        }
    }
}
