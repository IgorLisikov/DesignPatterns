using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProblem
{
    public class HeadingNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("highlight-heading");
        }
    }
}
