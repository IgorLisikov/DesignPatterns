using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new NotificationServer();       // complex system
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("appId", "key");
            var message = new Message("Hello World");
            server.Send(authToken, message, "target");
            connection.Disconnect();                     //
        }
    }
}
