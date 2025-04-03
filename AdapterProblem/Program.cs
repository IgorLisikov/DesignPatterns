using AdapterProblem.ThirdPartyLibraryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            // imageView.Apply(new BlackAndWhite()); // can't use it because it does not implement IFilter interface
        }
    }
}
