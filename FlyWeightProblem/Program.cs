﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PointService();
            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
        }
    }
}
