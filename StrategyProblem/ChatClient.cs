using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyProblem
{
    public class ChatClient
    {
        private string encryptionAlgorithm;

        public ChatClient(string encryptionAlgorithm)
        {
            this.encryptionAlgorithm = encryptionAlgorithm;
        }

        public void Send(string message)
        {
            if (encryptionAlgorithm == "DES")
                Console.WriteLine("Encrypting message using DES");
            else if (encryptionAlgorithm == "AES")
                Console.WriteLine("Encrypting message using AES");
            else
                throw new NotSupportedException("Unsupported encryption algorithm");

            Console.WriteLine("Sending the encrypted message...");
        }
    }

}
