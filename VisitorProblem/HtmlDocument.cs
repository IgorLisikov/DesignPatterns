using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProblem
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();
        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }
        public void Highlight()
        {
            foreach (var node in nodes)
            {
                node.Highlight();
            }
        }
    }
}
