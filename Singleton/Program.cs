﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(Method, Method);
        }

        private static void Method()
        {
            Singleton singleton = Singleton.Instance;
        }
    }
}
