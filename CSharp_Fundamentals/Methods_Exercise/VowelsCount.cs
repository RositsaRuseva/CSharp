using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(VowelsCount(input));

        }

        private static int VowelsCount(string input)
        {
            char[] letter = input.ToCharArray();
            int counter = 0;
            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] == 'A' || letter[i] == 'E'
                    || letter[i] == 'I' || letter[i] == 'O'
                    || letter[i] == 'U' || letter[i] == 'a'
                    || letter[i] == 'e' || letter[i] == 'i'
                    || letter[i] == 'o' || letter[i] == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
