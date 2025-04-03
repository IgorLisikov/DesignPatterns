using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PointService(new PointIconFactory());
            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
        }
    }
}
