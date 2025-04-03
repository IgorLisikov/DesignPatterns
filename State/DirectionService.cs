using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class DirectionService
    {
        private TravelMode travelMode;

        public int GetEta()
        {
            if (travelMode == TravelMode.DRIVING)
            {
                Console.WriteLine("Calculating ETA (driving)");
                return 1;
            }
            else if (travelMode == TravelMode.BICYCLING)
            {
                Console.WriteLine("Calculating ETA (bicycling)");
                return 2;
            }
            else if (travelMode == TravelMode.TRANSIT)
            {
                Console.WriteLine("Calculating ETA (transit)");
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating ETA (walking)");
                return 4;
            }
        }

        public int GetDirection()
        {
            if (travelMode == TravelMode.DRIVING)
            {
                Console.WriteLine("Calculating Direction (driving)");
                return 1;
            }
            else if (travelMode == TravelMode.BICYCLING)
            {
                Console.WriteLine("Calculating Direction (bicycling)");
                return 2;
            }
            else if (travelMode == TravelMode.TRANSIT)
            {
                Console.WriteLine("Calculating Direction (transit)");
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating Direction (walking)");
                return 4;
            }
        }

        public TravelMode GetTravelMode()
        {
            return travelMode;
        }

        public void SetTravelMode(TravelMode travelMode)
        {
            this.travelMode = travelMode;
        }
    }
}
