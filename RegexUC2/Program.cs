using System;

namespace RegexUC2
{
    class Program
    {
        public static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            RegexLastName registration = new RegexLastName();
                registration.LastName();

                Console.WriteLine("Welcome to User Registration");
                Console.WriteLine("\n Please enter  First Name--");
                string LastName = Console.ReadLine();
            RegexLastName.LastName(LastName);                                          //taking user input and passing it in first name method of regular exp class
                Console.ReadLine();
            }
    }
}
