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
        public static string regex_lastName = "^[A-Z]{1}[a-z]{2,}$";
        public static string regex_email = "^[a-z0-9]+(.[a-z0-9]+)?@[a-z]+[.][a-z]{2,3}(.[a-z]{2})?$";
        public static string regex_mobile = "^[1-9][0-9]{1,2}[ ][0-9]{10}$";
        public static string regex_passwordRule1 = "^[a-zA-Z0-9]{8,}$";
        public static string regex_passwordRule2 = "^(?=.*[A-Z])[A-Za-z0-9]{8,}$";
        public static string regex_passwordRule3 = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";
        public static string regex_passwordRule4 = "^(?=.*[A-Z])(?=.*[0-9])(?=.+[!@#$%^&*])[a-zA-Z0-9]{8,}$";

        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, regex_firstName).Equals(true))
            {
                Console.WriteLine("Validation successfull.");
            }
            else
            {
                Console.WriteLine("Hint : First Name should start with capital letter and should have minumim three characters");
            }
        }
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, regex_lastName).Equals(true))
            {
                Console.WriteLine("Validation successfull.");
            }
            else
            {
                Console.WriteLine("Hint : Last Name should starts with capital letter and should have minumim three characters");
            }
        }
        public void ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, regex_email).Equals(true))
            {
                Console.WriteLine("Validation successfull");
            }
            else
            {
                Console.WriteLine("Hint : e.g abc.xyz@bl.co.in \nEmail has 3 mandatory parts (abc, bl,co) and 2 optional parts(xyz,in) precise @ and.positions");
            }
        }
        public void ValidateMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, regex_mobile).Equals(true))
            {
                Console.WriteLine("Validation successfull");
            }
            else
            {
                Console.WriteLine("Hint : Mobile Format - E.g. 91 9919819801 - Country code follow by space and 10 digit number");
            }
        }
        public void ValidatePasswordRule1(string passwordrule1)
        {
            if (Regex.IsMatch(passwordrule1, regex_passwordRule1).Equals(true))
            {
                Console.WriteLine("Validation successfull");
            }
            else
            {
                Console.WriteLine("Hint : Password should be minimum 8 characters");
            }
        }
        public void ValidatePasswordRule2(string passwordrule2)
        {
            if (Regex.IsMatch(passwordrule2, regex_passwordRule2).Equals(true))
            {
                Console.WriteLine("Validation successfull");
            }
            else
            {
                Console.WriteLine("Hint : Rule 1: Password should have minimum 8 characters\n Rule2:Password should have at least 1 Upper Case");
            }
        }
        public void ValidatePasswordRule3(string passwordrule3)
        {
            if (Regex.IsMatch(passwordrule3, regex_passwordRule3).Equals(true))
            {
                Console.WriteLine("Validation successfull");
            }
            else
            {
                Console.WriteLine("Hint : Rule 1: Password should have minimum 8 characters\n Rule2:Password should have at least 1 Upper Case\n Rule3:Password should have atleast 1 Numeric number");
            }
        }
        public void ValidatePasswordRule4(string passwordrule4)
        {
            if (Regex.IsMatch(passwordrule4, regex_passwordRule4).Equals(true))
            {
                Console.WriteLine("Validation successfull");
            }
            else
            {
                Console.WriteLine("Hint : Rule 1: Password should have minimum 8 characters\n Rule2:Password should have at least 1 Upper Case\n Rule3:Password should have atleast 1 Numeric number\n Rule4:Password should have exactly 1 special character");
            }
        }
    }
}
       
    