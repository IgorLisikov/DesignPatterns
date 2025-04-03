using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ProductCollection();
            collection.Add(new Product(1, "name1"));
            collection.Add(new Product(2, "name2"));
            collection.Add(new Product(3, "name3"));

            var iterator = collection.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.MoveNext();
            }
        }
    }
}
