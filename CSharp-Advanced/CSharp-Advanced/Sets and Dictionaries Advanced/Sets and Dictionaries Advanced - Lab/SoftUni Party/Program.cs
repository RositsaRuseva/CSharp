using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string guests = string.Empty;
            var vip = new HashSet<string>();
            var regular = new HashSet<string>();
            while ((guests = Console.ReadLine()) != "PARTY")
            {
                if (ListStartsWithDigit(guests))
                {
                    vip.Add(guests);
                }
                else
                {
                    regular.Add(guests);
                }
            }
            while ((guests = Console.ReadLine()) != "END")
            {
                if (vip.Contains(guests))
                {
                    vip.Remove(guests);
                }
                if(regular.Contains(guests))
                {
                    regular.Remove(guests);
                }
                
            }
            Console.WriteLine(vip.Count + regular.Count);

            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }

            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }  
        }

        private static bool ListStartsWithDigit(string guests)
        {
            return guests.StartsWith("0") || guests.StartsWith("1")
                                || guests.StartsWith("2") || guests.StartsWith("3")
                                || guests.StartsWith("4") || guests.StartsWith("5")
                                || guests.StartsWith("6") || guests.StartsWith("7")
                                || guests.StartsWith("8") || guests.StartsWith("9");
        }
    }
}
