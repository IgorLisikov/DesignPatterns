using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyProblem
{
    public class Library
    {
        private Dictionary<string, Book> books = new Dictionary<string, Book>();

        public void Add(Book book)
        {
            books.Add(book.GetFileName(), book);
        }

        public void OpenBook(string fileName)
        {
            books[fileName].Show();
        }
    }
}
