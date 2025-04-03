using AdapterSolution.ThirdPartyLibraryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            imageView.Apply(new BlackAndWhiteFilter(new BlackAndWhite())); // IFilter interface is implemented by adapter (BlackAndWhiteFilter)
        }
    }
}
