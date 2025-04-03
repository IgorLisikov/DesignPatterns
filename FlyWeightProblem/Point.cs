using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightProblem
{
    public class Point
    {
        private int x;  // 4 bytes
        private int y;  // 4 bytes
        PointType type; // 4 bytes
        private byte[] icon;  // 20 kbytes  -  when creating objects same icon can be stored multiple times and consume memory

        public Point(int x, int y, PointType type, byte[] icon)
        {
            this.x = x;
            this.y = y;
            this.type = type;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{type} at {x}, {y}");
        }
    }
}
