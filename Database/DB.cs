using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public abstract class DB
    {
        private string _connectionString;
        private string _server;
        protected SqlConnection? _connection;

        public DB(string server, string dbName, string user, string password)
        {
            this._connectionString = $"Data source={server}; Initial Catalog={dbName};" +
                $"User={user}; Password={password}";
            this._server = server;
        }

        public void Connect()
        {
            //Console.WriteLine($"Connecting to the database on server {_server}");
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void Disconnect()
        {
            if( _connection != null && _connection.State == System.Data.ConnectionState.Open )
            {
                _connection.Close();
            }
        }
    }
}
