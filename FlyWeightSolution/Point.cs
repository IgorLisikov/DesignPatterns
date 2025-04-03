using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSolution
{
    public class Point
    {
        private int x;
        private int y;
        private PointIcon icon;

        public Point(int x, int y, PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{icon.GetType()} at {x}, {y}");
        }
    }
}
