using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSolution
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();  // each icon stored single time
        public PointIcon GetPointIcon(PointType type)
        {
            if (!icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                icons.Add(type, icon);
            }
            return icons[type];
        }
    }
}
