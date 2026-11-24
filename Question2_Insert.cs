using System;
using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class Question2_Insert
    {
        public static void Run()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                string course = Console.ReadLine()!;

                Console.Write("Enter City: ");
                string city = Console.ReadLine()!;

                string query = "INSERT INTO Student (Name, Age, Course, City) VALUES (@Name, @Age, @Course, @City)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@City", city);

                int result = cmd.ExecuteNonQuery();

                Console.WriteLine(result + " Record Inserted Successfully!");
            }
        }
    }
}