using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new NotificationService();  // simple interface to a complex system
            service.Send("Hello World", "target");
        }
    }
}
