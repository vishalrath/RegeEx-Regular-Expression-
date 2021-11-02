using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUc5Rule1
{
    class PasswordRule1
    {
        
        string[] passwordInputs = { "vishalfh", "bdhdb", "Vishal", "Vishalrathod", "rathodab" };
        string passPattern = "^[a-z]{8}$";

        public void Validation()
        {
            Regex regex = new Regex(passPattern);
            Console.WriteLine(" password Validation ");
            foreach (string word in passwordInputs)
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

