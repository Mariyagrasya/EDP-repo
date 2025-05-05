using MySql.Data.MySqlClient;
using System;

namespace brgyProfiling
{
    internal class conn
    {
        // Connection string (update with your database details)
        private static string connectionString = "Server=localhost;Database=brgyprofilingsys;User ID=root;Password=159632;";

        // Method to get a MySQL connection
        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
                throw;
            }
        }
    }
}
