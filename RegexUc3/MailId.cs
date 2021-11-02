using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUc3
{
    class MailId
    {
        string[] emailInputs = { "abc.xyz@bl.co.in", "abc@bl.co.in", "abc.x@gm.co.in", "abc.xyzbl.co.in", "abc,xyz@bl.in", "ab.xyz@bl.co.in", "abc.nxcst@bl.co.in" };
        string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";

        public void Validation()
        {
            Regex regex = new Regex(emailPattern);
            Console.WriteLine(" Email Validation ");
            foreach (string word in emailInputs)
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



        // taking inputs fron user
        public static void FirstEmail(string name)                   //declaring the static method 
        {
            string mailIdPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";            //its expretion show the first 3 small letter word then . then same letter and @ symbol then .co.in
            Regex regex = new Regex(mailIdPattern);
            if (regex.IsMatch(name))                               //calling the Regex class's functions
            {
                Console.WriteLine(name + " is valid");
            }
            else
                Console.WriteLine(name + " is invalid. Please check mail id enter valid MailId.");
        }
    }
}
