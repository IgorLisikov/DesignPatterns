using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProblem
{
    public class AnchorNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}
