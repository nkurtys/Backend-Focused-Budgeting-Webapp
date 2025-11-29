using Npgsql;

namespace Project.API.Data
{
    internal class Project
    {
        private static void Main(string[] args)
        {
            try{
                    // Define your connection string
                const string connString = "Host=localhost;Username=postgresDB;Password=1234;Database=postgres";

                // Create and open a connection to the PostgreSQL database
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Example query to test connection
                    using (var cmd = new NpgsqlCommand("SELECT version()", conn))
                    {
                        string version = cmd.ExecuteScalar().ToString();
                        Console.WriteLine($"PostgreSQL version: {version}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }
    }
}


