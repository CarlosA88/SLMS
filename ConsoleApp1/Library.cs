using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        public void AddBook(Book book) { }

    public void RemoveBook(string isbn) { }

        public void CheckOutBook(string isbn) { }
        public void ReturnBook(string isbn) { }

        public List<Book> ListAvailableBooks()
        {
            return new List<Book>();
        }

    }
}
