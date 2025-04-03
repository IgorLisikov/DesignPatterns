using StrategySolution.EncryptionAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolution
{
    public class ChatClient
    {
        public void Send(string message, IEncryptionAlgorithm encryptionAlgorithm)
        {
            var encryptedMessage =  encryptionAlgorithm.Encrypt(message);
            Console.WriteLine("Sending the encrypted message...");
        }
    }

}
