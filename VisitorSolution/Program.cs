using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorSolution.Visitors;

namespace VisitorSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Accept(new HighlightOperation());
            document.Accept(new PlainTextOperation());
        }
    }
}
