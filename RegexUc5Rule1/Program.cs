using System;

namespace RegexUc5Rule1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PasswordRule1 password = new PasswordRule1();
            password.Validation();
            Console.ReadLine();
        }
    }
}
