using StrategySolution.EncryptionAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatClient = new ChatClient();
            chatClient.Send("Hello", new AES());
        }
    }
}
