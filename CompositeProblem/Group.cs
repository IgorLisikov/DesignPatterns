using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProblem
{
    public class Group
    {
        private List<Shape> shapes = new List<Shape>();

        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void Render()
        {
            foreach (var shape in shapes)
            {
                shape.Render();
            }
        }
    }
}
