using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOld.Factory
{
    public class NoSqlConnectionFactory : ConnectionFactory
    {
        public override Connection GetConnection()
        {
            return new NoSqlConnection();
        }
    }
}
