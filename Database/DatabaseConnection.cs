using System.Configuration;
using MySql.Data.MySqlClient;

namespace eshift.Database
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> _instance =
            new(() => new DatabaseConnection());

        private readonly string _connectionString;

        private DatabaseConnection()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public static DatabaseConnection Instance => _instance.Value;

        public MySqlConnection Connection
        {
            get
            {
                var connection = new MySqlConnection(_connectionString);
                connection.Open();
                return connection;
            }
        }

        public static string ConnectionString => 
            ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
    }
}
