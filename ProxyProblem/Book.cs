using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyProblem
{
    public class Book
    {
        private string fileName;

        public Book(string fileName)
        {
            this.fileName = fileName;
            Load();                      // costly loading
        }

        private void Load()
        {
            Console.WriteLine("Loading the book " + fileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing the book " + fileName);
        }

        public string GetFileName()
        {
            return fileName;
        }
    }
}
