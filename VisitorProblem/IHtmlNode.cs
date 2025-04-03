using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProblem
{
    public interface IHtmlNode  //every time we want to introduce a new operation we need to change every object in the structure
    {
        void Highlight();
    }
}
