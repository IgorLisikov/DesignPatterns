using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var cloudStream = new CloudStream();
            cloudStream.Write("Some data");

            var encryptedcloudStream = new EncryptedCloudStream();  // If need to encrypt and compress data, need to add
            encryptedcloudStream.Write("Some data");                // new class called "EncryptedAndCompressedCloudStream".
                                                                    // There is no option to combine additional behaviour
            var compressedCloudStream = new CompressedCloudStream();
            compressedCloudStream.Write("Some data");
        }
    }
}
