using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Highlight();
        }
    }
}
