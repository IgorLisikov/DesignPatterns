using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProblem
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();  // To iterate over this list, it needs to be public;
        // If make it public, then using this collection from outside of this class will make the outer code
        // to be coupled with the type of this collection. And changing the type of the collection will break the outer code.

        public void Add(Product product)
        {
            products.Add(product);
        }
    }
}
