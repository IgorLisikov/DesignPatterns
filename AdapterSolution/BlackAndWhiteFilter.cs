using AdapterSolution.ThirdPartyLibraryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSolution
{
    public class BlackAndWhiteFilter : IFilter    // This is adapter class
    {
        private BlackAndWhite blackAndWhite;

        public BlackAndWhiteFilter(BlackAndWhite blackAndWhite)
        {
            this.blackAndWhite = blackAndWhite;
        }

        public void Apply(Image image)
        {
            blackAndWhite.Init();
            blackAndWhite.Render(image);
        }
    }
}
