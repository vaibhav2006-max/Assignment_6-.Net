using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class Question7_Update
    {
        public static void Run()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT * FROM Student", con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Student");

                SqlCommandBuilder builder =
                    new SqlCommandBuilder(adapter);

                Console.Write("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                DataRow[] rows =
                    ds.Tables["Student"]!.Select("StudentID = " + id);

                if (rows.Length > 0)
                {
                    Console.Write("Enter New City: ");
                    rows[0]["City"] = Console.ReadLine()!;

                    adapter.Update(ds, "Student");

                    Console.WriteLine("Record Updated Successfully!");
                }
                else
                {
                    Console.WriteLine("Student Not Found!");
                }
            }
        }
    }
}