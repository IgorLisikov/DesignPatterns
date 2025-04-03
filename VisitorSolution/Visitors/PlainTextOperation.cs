using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorSolution.Visitors
{
    public class PlainTextOperation : IVisitor  // adding new operation without modifying existing code
    {
        public void Visit(AnchorNode anchor)
        {
            Console.WriteLine("plaintext-anchor");
        }

        public void Visit(HeadingNode heading)
        {
            Console.WriteLine("plaintext-heading");
        }
    }
}
