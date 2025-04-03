using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSolution
{
    public class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Rendering a shape");
        }

        public void Move()
        {
            Console.WriteLine("Moving a shape");
        }
    }
}
