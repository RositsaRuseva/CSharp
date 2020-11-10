using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleChar(input));

        }

        static string MiddleChar(string input)
        {
            string middle = string.Empty;
            if(input.Length >0 && input.Length%2 == 0)
            {
                middle = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString(); 
            }
            else
            {
                middle = input[input.Length / 2].ToString();
            }
            return middle;
        }
    }
}
