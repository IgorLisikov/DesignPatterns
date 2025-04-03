using StateSolution.TravelModes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DirectionService(new Walking());
            service.GetEta();
            service.GetDirection();
        }
    }
}
