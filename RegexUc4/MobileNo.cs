using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUc4
{
    class MobileNo
    {
        string[] Inputs = { "91 9986522051", "01 6886531051", "918686531051", "91 86865310", "91 6223344556", "91 868653105112" };
        string mobileNoPattern = "[1-9]{2}[ ]{1}[0-9]{10}";

        public void Validation()
        {
            Regex regex = new Regex(mobileNoPattern);
            Console.WriteLine(" Mobile Validation ");
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
