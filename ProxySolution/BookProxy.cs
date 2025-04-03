using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySolution
{
    public class BookProxy : IBook
    {
        private string fileName;
        private RealBook realBook;  // no initialization, initialize only when field is used (Lazy)

        public BookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if (realBook == null)
                realBook = new RealBook(fileName);  // costly loading

            realBook.Show();
        }
    }
}
