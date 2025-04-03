using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Connection
    {
        public static Connection GetConnection(string type)
        {
            Connection connection = null;
            switch (type)
            {
                case "Sql": connection = new SqlConnection();
                    break;
                case "NoSql": connection = new NoSqlConnection();
                    break;
            }

            return connection;
        }
    }
}
