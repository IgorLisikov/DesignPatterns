using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorSolution.Visitors;

namespace VisitorSolution
{
    public class HeadingNode : IHtmlNode
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
