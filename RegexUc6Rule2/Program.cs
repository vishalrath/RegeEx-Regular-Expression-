using System;

namespace RegexUc6Rule2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PasswordRule2 password = new PasswordRule2();
            password.Validation();
            Console.ReadLine();
        }
    }
}
