using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class DBConnection
    {
        public static string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}