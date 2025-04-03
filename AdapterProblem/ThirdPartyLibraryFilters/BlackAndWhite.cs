using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblem.ThirdPartyLibraryFilters
{
    public class BlackAndWhite
    {
        public void Init()
        {
        }

        public void Render(Image image)
        {
            Console.WriteLine("applying balck and white filter");
        }
    }
}
