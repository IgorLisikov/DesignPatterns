using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorSolution.Visitors;

namespace VisitorSolution
{
    public interface IHtmlNode
    {
        void Accept(IVisitor visitor);
    }
}
