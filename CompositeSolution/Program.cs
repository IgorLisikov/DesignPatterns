using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSolution
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
            group.Add(group1);  // Can add group inside a group
            group.Add(group2);

            group.Render();
            group.Move();
        }
    }
}
