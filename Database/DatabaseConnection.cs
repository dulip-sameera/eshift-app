using System.Configuration;
using MySql.Data.MySqlClient;

namespace eshift.Database
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> _instance =
            new(() => new DatabaseConnection());

        private MySqlConnection _connection;
        private readonly string _connectionString;

        private DatabaseConnection()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["MySqlConnection"].ConnectionString;
            _connection = new MySqlConnection(_connectionString);
        }

        public static DatabaseConnection Instance => _instance.Value;

        public MySqlConnection Connection
        {
            get
            {
                // If connection is disposed, create a new one
                if (_connection == null || _connection.State == System.Data.ConnectionState.Broken)
                {
                    _connection = new MySqlConnection(_connectionString);
                }
                // If connection is closed, open it
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        public void Close()
        {
            if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
            {
                return;
            }
            _connection.Close();
        }
    }
}
