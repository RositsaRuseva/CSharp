using System;
using System.Linq;
using System.Collections.Generic;

namespace MixedUpLines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> storageList = new List<int>();
            List<int> newList = new List<int>();

            input2.Reverse();
            if(input1.Count>input2.Count)
            {
                storageList.Add(input1[input1.Count - 1]);
                storageList.Add(input1[input1.Count - 2]);
                input1.RemoveAt(input1.Count - 1);
                input1.RemoveAt(input1.Count - 1);
            }
            if(input2.Count > input1.Count)
            {
                storageList.Add(input2[input2.Count - 1]);
                storageList.Add(input2[input2.Count - 2]);
                input2.RemoveAt(input2.Count - 1);
                input2.RemoveAt(input2.Count - 1);
            }

            int i = 0;
           
            // while(i< input1.Count)
            //{
            //  newList[k++] = input1[i++];
            //}
            //while(j<input2.Count)
            //{
            //  newList[k++] = input2[j++];
            //}
            for (i = 0; i < input1.Count; i++)
            {
                
                    newList.Add(input1[i]);
                    newList.Add(input2[i]);
                
            }
            storageList.Sort();
            newList.Sort();

            newList.RemoveAll(x => x <= storageList[0]);
            newList.RemoveAll(x => x >= storageList[1]);
            
            //Console.WriteLine(String.Join(" ",input1));
            //Console.WriteLine(String.Join(" ",input2));
            Console.WriteLine(String.Join(" ", newList));

        }
    }
}
