using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegaxUc8Rule4
{
    class passordRule4
    {

        string[] Inputs = { "Vish@lh1", "abc1sd&v", "$yzYzv3b", "Vishal1ath@d", "abcds", "#Abcds0x", "raj^8haI","hvfcg5*" };
        string passPattern = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8}$";


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
