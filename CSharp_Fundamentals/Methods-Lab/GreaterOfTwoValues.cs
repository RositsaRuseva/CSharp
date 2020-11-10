using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine().ToLower();

            switch (valueType)
            {
                case "int":
                    int value1 = int.Parse(Console.ReadLine());
                    int value2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxInt(value1, value2));

                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxChar(char1, char2));

                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();

                    Console.WriteLine(GetMaxString(str1, str2));

                    break;

            }

        }

        static int GetMaxInt(int value1, int value2)
        {
            if(value1 > value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
        static char GetMaxChar(char char1, char char2)
        {
            if(char1 > char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }
        static string GetMaxString(string str1, string str2)
        {
            if(str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
    }
}

