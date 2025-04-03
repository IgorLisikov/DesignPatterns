using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorSolution.Visitors;

namespace VisitorSolution
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();
        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (var node in nodes)
            {
                node.Accept(visitor);
            }
        }
    }
}
