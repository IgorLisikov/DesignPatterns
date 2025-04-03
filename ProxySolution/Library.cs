using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySolution
{
    public class Library
    {
        private Dictionary<string, IBook> books = new Dictionary<string, IBook>();

        public void Add(IBook book)
        {
            books.Add(book.GetFileName(), book);
        }

        public void OpenBook(string fileName)
        {
            books[fileName].Show();
        }
    }
}
