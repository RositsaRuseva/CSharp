using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int operation = 0;
            int position = 0;
            string command = Console.ReadLine();

            while (command != "end")
            {
                

                string[] elements = command.Split();

                if(elements[0] == "Delete")
                {
                    operation = int.Parse(elements[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(numbers[i] == operation)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                    
                    
                }
                else if (elements[0] == "Insert")
                {
                    operation = int.Parse(elements[1]);
                    position = int.Parse(elements[2]);

                    numbers.Insert(position, operation);

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
