using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorSolution.Visitors
{
    public class HighlightOperation : IVisitor  // all logic related to this type of operation is in one single place
    {
        public void Visit(AnchorNode anchor)
        {
            Console.WriteLine("highlight-anchor");
        }

        public void Visit(HeadingNode heading)
        {
            Console.WriteLine("highlight-heading");
        }
    }
}
