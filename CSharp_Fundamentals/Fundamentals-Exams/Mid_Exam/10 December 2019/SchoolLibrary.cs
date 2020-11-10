using System;
using System.Linq;
using System.Collections.Generic;


namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&").ToList();

            string input = Console.ReadLine();

            while ((input != "Done"))
            {
                string[] command = input.Split(" | ");
                string operation = command[0];
                if (operation == "Add Book")
                {
                    string book = command[1];
                    if (!books.Contains(book))
                    {
                        books.Insert(0, book);
                    }
                }
                if (operation == "Take Book")
                {
                    string bookName = command[1];
                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                    }
                }
                if (operation == "Swap Books")
                {
                    string bookName = command[1];
                    string secondBook = command[2];
                    if (books.Contains(bookName) && books.Contains(secondBook))
                    {                      
                        int indexFirst = books.IndexOf(bookName);
                        int indexSecond = books.IndexOf(secondBook);
                        string temp1 = books[indexFirst];
                        string temp2 = books[indexSecond];
                        books[indexFirst] = temp2;
                        books[indexSecond] = temp1;
                    }
                }
                if (operation == "Insert Book")
                {
                    string bookName = command[1];
                    books.Add(bookName);
                }
                if(operation == "Check Book")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index <= books.Count)
                    {
                        Console.WriteLine($"{books[index]}");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", books));
        }
    }
}
