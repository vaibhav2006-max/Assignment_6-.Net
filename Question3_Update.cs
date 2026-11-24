using System;
using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class Question3_Update
    {
        public static void Run()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                Console.Write("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New City: ");
                string city = Console.ReadLine()!;

                string query = "UPDATE Student SET City=@City WHERE StudentID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@ID", id);

                int result = cmd.ExecuteNonQuery();

                Console.WriteLine(result + " Record Updated Successfully!");
            }
        }
    }
}