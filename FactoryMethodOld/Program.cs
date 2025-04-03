using FactoryMethodOld.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOld
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory factory = new SqlConnectionFactory();
            Connection connection = factory.GetConnection();
        }
    }
}
