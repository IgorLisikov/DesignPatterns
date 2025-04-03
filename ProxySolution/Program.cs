using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            string[] fileNames = { "a", "b", "c" };

            foreach (var fileName in fileNames)
            {
                library.Add(new BookProxy(fileName));  // loading a real book is costly
            }

            library.OpenBook("a");
        }
    }
}
