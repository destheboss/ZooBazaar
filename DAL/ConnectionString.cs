using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConnectionString
    {
        public static MySqlConnection Connection()
        {
            return new MySqlConnection("server=localhost;database=YOUR DATABASE;uid=root;pwd=YOUR OWN PASSWORD");
        }
    }
}
