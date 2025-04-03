using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://csharpindepth.com/Articles/Singleton#cctor

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton(); // thread safe, eager loading

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
        }

        private Singleton()
        {
            Console.WriteLine("in ctor");
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
