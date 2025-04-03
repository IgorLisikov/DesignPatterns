using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProblem.Framework
{
    public class Button : UIControl
    {
        private bool isEnabled;

        public bool IsEnabled()
        {
            return isEnabled;
        }

        public void SetEnabled(bool enabled)
        {
            isEnabled = enabled;
        }
    }
}
