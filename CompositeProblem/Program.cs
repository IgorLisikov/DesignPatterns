using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group();
            group1.Add(new Shape());  // square
            group1.Add(new Shape());  // square

            var group2 = new Group();
            group2.Add(new Shape());  // circle
            group2.Add(new Shape());  // circle

            var group = new Group();
            // group.Add(group1);  // Can't add group inside a group
        }
    }
}
