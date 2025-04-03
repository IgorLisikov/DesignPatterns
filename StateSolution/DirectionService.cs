using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    public class DirectionService
    {
        private ITravelMode travelMode;
        public DirectionService(ITravelMode travelMode)
        {
            this.travelMode = travelMode;
        }

        public int GetEta()
        {
            return travelMode.GetEta();
        }

        public int GetDirection()
        {
            return travelMode.GetDirection();
        }

        public ITravelMode GetTravelMode()
        {
            return travelMode;
        }

        public void SetTravelMode(ITravelMode travelMode)
        {
            this.travelMode = travelMode;
        }
    }
}
