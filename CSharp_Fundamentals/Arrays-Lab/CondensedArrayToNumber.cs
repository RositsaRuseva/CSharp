using System;
using System.Linq;
namespace CondenceArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedArr = new int[mainArr.Length - 1];

            if (mainArr.Length == 1)
            {
                Console.WriteLine(mainArr[0]);
                return;
            }

            for (int i = 0; i < mainArr.Length; i++)
            {
                for (int j = 0; j < condensedArr.Length - i; j++)
                {
                    condensedArr[j] = mainArr[j] + mainArr[j + 1];
                }
                mainArr = condensedArr;
            }
            Console.WriteLine(condensedArr[0]);
        }
    }
}
