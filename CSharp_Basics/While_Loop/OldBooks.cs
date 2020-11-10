using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;

            string currentBook = Console.ReadLine();
            while (currentBook != "No More Books")
            {


                if (currentBook == searchedBook)

                {
                    isBookFound = true;
                    break;
                }
                counter++;
                currentBook = Console.ReadLine();

            }
                


           if(isBookFound)
           {
                Console.WriteLine($"You checked {counter} books and found it.");
           }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            
        }
    }
}
