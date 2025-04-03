using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSolution
{
    public class Group : IComponent
    {
        private List<IComponent> shapes = new List<IComponent>();

        public void Add(IComponent shape)
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
        public void Move()
        {
            foreach (var shape in shapes)
            {
                shape.Move();
            }
        }
    }
}
