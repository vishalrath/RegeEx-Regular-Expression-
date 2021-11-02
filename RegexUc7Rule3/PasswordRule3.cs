using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUc7Rule3
{
    class PasswordRule3
    {
        string[] Inputs = { "Vishalh1", "abc1sdcv", "xyzYzv3b", "Vishalrathod", "abcds", "Abcds0x", "raju8haI" };
        string passPattern = "^(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]{8}$";

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
