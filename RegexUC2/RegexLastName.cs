using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUC2
{
    class RegexLastName
    {
            // taking inputs fron user
        public static void LastName(string name)                   //declaring the static method 
        {
            string LastName = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(name))                               //calling the Regex class's functions
            {
                Console.WriteLine(name + " is valid");
            }
            else
                Console.WriteLine(name + " is invalid. Please check your name and start with capital letter.");
        }

          //defualt input
        string[] inputs = { "Rathod", "Jadhav", "rat", "chavhan", "abc" };
        string pattern = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3

        
         public void LastName()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("last name   Validation ");
            foreach (string word in inputs)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }
    }
}
