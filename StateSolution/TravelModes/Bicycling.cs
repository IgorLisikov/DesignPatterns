using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution.TravelModes
{
    public class Bicycling : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }
    }
}
