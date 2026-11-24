using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class Question8_Delete
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
                    rows[0].Delete();

                    adapter.Update(ds, "Student");

                    Console.WriteLine("Record Deleted Successfully!");
                }
                else
                {
                    Console.WriteLine("Student Not Found!");
                }
            }
        }
    }
}