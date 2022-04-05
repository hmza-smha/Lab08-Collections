using System;

namespace Lab08_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library<Book> lib = new Library<Book>();

            lib.Add("1", "HamZa", "Akram", 5);
            lib.Add("2", "Mutaz", "Altbakhi", 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Count: " + lib.Count);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("My Books :");
            foreach (Book book in lib)
            {
                Console.WriteLine(book.Author);
            }
            Console.WriteLine();
            Backpack<Book> bp = new Backpack<Book>();
            bp.Pack(lib.Borrow("2"));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("My Pack : ");
            foreach (var book in bp)
            {
                Console.WriteLine(book.Author);
            }
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}