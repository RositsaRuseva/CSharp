using System;
using System.Linq;
using System.Collections.Generic;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<string> secondInput = Console.ReadLine().Split().ToList();
            string secondInput = Console.ReadLine();

            for (int i = 0; i < firstInput.Count; i++)
            {
                int currentNumber = firstInput[i];
                int index = CalculateSum(currentNumber);

                char currentChar = GetCharFromMessage(index, secondInput);
                Console.Write(currentChar);

                int realIndex = CalculateRealIndex(index, secondInput);
                string newMessage = secondInput.Remove(realIndex, 1);
                secondInput = newMessage;
            }
            Console.WriteLine();
            

            

        }
        static int CalculateSum(int element)
        {
            int index = 0;
            while(element >0)
            {
                int currentNumber = element % 10;
                index += currentNumber;
                element /= 10;
            }
            return index;
        }
        static char GetCharFromMessage(int index, string secondInput)
        {
            int count = 0;

            for (int i = 0; i < index; i++)
            {
                count++;
                if(count == secondInput.Length)
                {
                    count = 0;
                }
            }
            char currentChar = secondInput[count];
            return currentChar;
            
        }
        static int CalculateRealIndex(int index, string secondInput)
        {
            int count = 0;
            for (int i = 0; i < index; i++)
            {
                count++;
                if(count >= secondInput.Length)
                {
                    count = 0;
                }

            }
            return count;
            {

            }
        }
    }
}
