using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUc6Rule2
{
    class PasswordRule2
    {


        string[] Inputs = { "Vishalhi", "abcvsdcv", "xyzYzvab", "Vishalrathod", "abcds", "Abcdsgx", "rajubhaI" };
        string passPattern = "^(?=.*[A-Z])[a-zA-Z]{8}$";
      
        public void Validation()
        {
            Regex regex = new Regex(passPattern);
            Console.WriteLine(" password Validation ");
            foreach (string word in Inputs)
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
