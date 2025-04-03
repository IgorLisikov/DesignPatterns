using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolution.EncryptionAlgorithms
{
    public class AES : IEncryptionAlgorithm
    {
        public string Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using AES");
            return "encryptedText";
        }
    }
}
