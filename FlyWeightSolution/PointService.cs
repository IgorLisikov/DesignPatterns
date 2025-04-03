using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSolution
{
    public class PointService
    {
        private PointIconFactory iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            return new List<Point>
            {
                new Point(1, 2, iconFactory.GetPointIcon(PointType.Cafe))
            };
        }
    }
}
