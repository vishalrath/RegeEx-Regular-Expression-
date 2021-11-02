using System;

namespace RegexUc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MailId newmail = new MailId();
            newmail.Validation();

            //input given from user
            Console.WriteLine("--Welcome to User Email Registration-");
            Console.WriteLine("\n Please Mail ID--");
            string iputmail = Console.ReadLine();
            MailId.FirstEmail(iputmail);                                          //taking user input and passing it in first name method of regular exp class
            Console.ReadLine();
        }
    }
}
