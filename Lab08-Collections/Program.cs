using System;

namespace Lab08_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();

            lib.Add("1", "HamZa", "Akram", 5);
            lib.Add("2", "Hello", "World", 10);

            Console.WriteLine("Count: " + lib.Count);

            Console.WriteLine("My Books");
            foreach (Book book in lib)
            {
                Console.WriteLine(book.Author);
            }

            Backpack<Book> bp = new Backpack<Book>();
            bp.Pack(lib.Borrow("2"));

            Console.WriteLine("My Pack");
            foreach (Book book in bp)
            {
                Console.WriteLine(book.Title);
            }


        }
    }
}
