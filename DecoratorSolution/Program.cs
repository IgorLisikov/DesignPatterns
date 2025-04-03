using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreCreditCard(new CloudStream());
            StoreCreditCard(new CompressedCloudStream(new CloudStream()));  // decorated with new behaviour
            StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));  // can be combined
        }

        public static void StoreCreditCard(IStream stream)
        {
            stream.Write("1234-1234-1234-1234");
        }
    }
}
