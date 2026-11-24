using System;
using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class Question4_Delete
    {
        public static void Run()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                Console.Write("Enter Student ID to Delete: ");
                int id = Convert.ToInt32(Console.ReadLine());

                string query = "DELETE FROM Student WHERE StudentID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", id);

                int result = cmd.ExecuteNonQuery();

                Console.WriteLine(result + " Record Deleted Successfully!");
            }
        }
    }
}