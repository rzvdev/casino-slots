using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizzlingHot
{
    class ConnectionInfo
    {
        /// <summary>
        /// Represent the connection info for the database
        /// </summary>
        private static string _SERVER = "server=127.0.0.1; ";
        private static string _DATABASE = "database=netdb; ";
        private static string _USER = "user=root; ";
        private static string _PWD = "pwd=root";

        protected ConnectionInfo()
        {

        }

        public static string GetServerAddress()
        {
            return _SERVER;
        }

        public static string GetDatabaseName()
        {
            return _DATABASE;
        }

        public static string GetConnectionString()
        {
            return _SERVER + _DATABASE + _USER + _PWD;
        }
    }
}
