using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDay19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to User Registration Program..");
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            pattern.ValidateFirstName(firstName);
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            pattern.ValidateLastName(lastName);
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            pattern.ValidateEmail(email);
            Console.WriteLine("Enter Mobile number");
            string mobile = Console.ReadLine();
            pattern.ValidateMobile(mobile);
            Console.WriteLine("Enter Password");
            string passwordrule1 = Console.ReadLine();
            pattern.ValidatePasswordRule1(passwordrule1);
            Console.WriteLine("Enter Password");
            string passwordrule2 = Console.ReadLine();
            pattern.ValidatePasswordRule2(passwordrule2);

            Console.ReadKey();
        }
    }
}


