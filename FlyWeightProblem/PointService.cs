using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightProblem
{
    public class PointService
    {
        public List<Point> GetPoints()
        {
            return new List<Point>
            {
                new Point(1, 2, PointType.Cafe, null)
            };
        }
    }
}
