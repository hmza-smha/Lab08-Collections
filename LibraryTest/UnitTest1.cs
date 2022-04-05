using Lab08_Collections;
using System;
using System.Collections.Generic;
using Xunit;

namespace LibraryTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddBook()
        {
            Library<Book> lib = new Library<Book>();

            lib.Add("Hamza", "HamZa", "Akram", 6);
            Assert.NotEmpty(lib);
        }

        [Fact]
        public void CanRemoveBook()
        {
            Library<Book> lib = new Library<Book>();

            lib.Add("Hamza", "HamZa", "Akram", 6);
            Book book = new Book("Hamza", "HamZa Akram", 6);
            lib.Borrow("Test");
            Assert.DoesNotContain(book, lib);
        }

        [Fact]
        public void CanBerrowMissingTitle()
        {
            Library<Book> lib = new Library<Book>();

            lib.Add("Hamza", "HamZa", "Akram", 6);
            //Book book = new Book("Test", "HamZa", 5);

            Assert.Null(lib.Borrow("TestTest"));
        }

        [Fact]
        public void ReturnedBookIsOnceAgain()
        {
            Library<Book> lib = new Library<Book>();

            lib.Add("Mutaz", "Mutaz", "Altbakhi", 5);
            lib.Add("Hamza", "HamZa", "Akram", 6);
            Book book = new Book("Hamza", "HamZa Akram", 6);
            Assert.Contains(book, lib);
        }
        [Fact]
        public void pack()
        {
            Backpack<string> bp = new Backpack<string>();
            //Book book = new Book("Test", "HamZa Akram", 5);
            string book = "Test";
            bp.Pack(book);
            List<string> lists = new List<string>();

            foreach (var item in bp)
            {
                lists.Add(item);
            }

            Assert.Contains(book, lists);
        }
    }
}
