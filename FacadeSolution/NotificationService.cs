using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSolution
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("appId", "key");
            server.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}
