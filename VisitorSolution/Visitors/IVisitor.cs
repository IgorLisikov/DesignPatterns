using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorSolution.Visitors
{
    public interface IVisitor
    {
        void Visit(AnchorNode anchor);
        void Visit(HeadingNode heading);
    }
}
