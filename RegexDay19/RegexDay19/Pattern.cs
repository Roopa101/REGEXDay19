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
        public static string regex_firstName = "^[A-Z]{1}[a-z]{2,}$";
        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, regex_firstName).Equals(true))
            {
                Console.WriteLine("Validation successfull");
            }
            else
            {
                Console.WriteLine("Hint : First Name should start with capital letter and should have minimum three characters");
            }
        }
    }
}
   