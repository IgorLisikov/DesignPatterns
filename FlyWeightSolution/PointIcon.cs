using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSolution
{
    public class PointIcon  // <- Flyweight
    {
        private readonly PointType type;
        private readonly byte[] icon;

        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }

        public new PointType GetType()
        {
            return type;
        }
    }
}
