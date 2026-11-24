using System;
using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class Question1_Display
    {
        public static void Run()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Student";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();

                Console.WriteLine("\nStudent Records:");

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        Console.Write(dr[i] + "\t");
                    }

                    Console.WriteLine();
                }

                dr.Close();
            }
        }
    }
}