using System;

namespace BookShop
{
    public class Program
    {
        static void Main()
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

    }
}
