using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections
{
    public class Library<T> : ILibrary
    {

        public int Count { get; set; }
        private Dictionary<string, Book> _books;

        public Library()
        {
            _books = new Dictionary<string, Book>();
        }

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(title, firstName + " " + lastName, numberOfPages);
            book.Title = title;
            book.Author = firstName + " " + lastName;
            book.NumberOfPages = numberOfPages;

            _books.Add(title, book);

            Count++;
        }

        public Book Borrow(string title)
        {
            if (_books.ContainsKey(title))
            {
                Book book = _books[title];
                _books.Remove(title);
                Count--;
                return book;
            }
            else { return null; }
        }

        public void Return(Book book)
        {
            if (book == null)
                return;

            _books.Add(book.Title, book);
            Count++;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book item in _books.Values)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}