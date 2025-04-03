using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOld.Factory
{
    public class SqlConnectionFactory : ConnectionFactory
    {
        public override Connection GetConnection()
        {
            return new SqlConnection();
        }
    }
}
