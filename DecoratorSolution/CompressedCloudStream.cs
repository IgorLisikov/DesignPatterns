using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolution
{
    public class CompressedCloudStream : IStream
    {
        private IStream stream;

        public CompressedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Compress(data);
            stream.Write(encrypted);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
