using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class Question6_Insert
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

                DataTable table = ds.Tables["Student"]!;

                DataRow row = table.NewRow();

                Console.Write("Enter Name: ");
                row["Name"] = Console.ReadLine()!;

                Console.Write("Enter Age: ");
                row["Age"] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                row["Course"] = Console.ReadLine()!;

                Console.Write("Enter City: ");
                row["City"] = Console.ReadLine()!;

                table.Rows.Add(row);

                adapter.Update(ds, "Student");

                Console.WriteLine("Record Inserted Successfully!");
            }
        }
    }
}