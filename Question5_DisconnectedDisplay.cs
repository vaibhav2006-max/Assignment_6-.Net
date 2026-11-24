using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Question5_DisconnectedDisplay
{
    public static void Run()
    {
        string cs = @"Data Source=.\SQLEXPRESS;
        Initial Catalog=StudentDB;
        Integrated Security=True;
        TrustServerCertificate=True;";

        try
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Student";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                Console.WriteLine("Student Records:");
                Console.WriteLine("-----------------------------");

                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item + "\t");
                    }

                    Console.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}