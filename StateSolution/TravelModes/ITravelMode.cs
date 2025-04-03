using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    public interface ITravelMode
    {
        int GetEta();
        int GetDirection();
    }
}
