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
           
            Console.ReadKey();
        }
    }
}


