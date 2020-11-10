using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PasswordValidator(input);

        }

        static void PasswordValidator(string input)
        {
            if (input.Count(Char.IsDigit) >= 2 && input.Length >= 6 && input.Length <= 10 && input.All(Char.IsLetterOrDigit))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!(input.Length >= 6 && input.Length <= 10))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!input.All(Char.IsLetterOrDigit))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!(input.Count(Char.IsDigit) >= 2))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
    }
}
