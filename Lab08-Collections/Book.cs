using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int NumberOfPages { get; set; }

        public Book(string title, string auther, int numberOfPages)
        {
            this.Title = title;
            this.Author = auther;
            this.NumberOfPages = numberOfPages;
        }
    }
}