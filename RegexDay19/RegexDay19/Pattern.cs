using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexDay19
{
    class Pattern
    {
        public static string regex_lastName = "^[A-Za-z]{2,}[A-z]{1}$";
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, regex_lastName).Equals(true))
            {
                Console.WriteLine("Validation successfull");
            }
            else
            {
                Console.WriteLine("Hint : Last Name should End with capital letter and should have minimum three characters");
            }
        }
    }
}
   