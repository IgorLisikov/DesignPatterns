using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProblem
{
    public class Product
    {
        private int id;
        private string name;

        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

      public override string ToString()
        {
            return "Product{" +
                    "id=" + id +
                    ", name='" + name + '\'' +
                    '}';
        }
    }

}
