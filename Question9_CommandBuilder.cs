using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace StudentConnection
{
    public class Question9_CommandBuilder
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

                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");

                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                DataTable table = ds.Tables["Student"]!;

                if (choice == 1)
                {
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
                }
                else
                {
                    Console.Write("Enter Student ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    DataRow[] rows =
                        table.Select("StudentID = " + id);

                    if (rows.Length == 0)
                    {
                        Console.WriteLine("Student Not Found!");
                        return;
                    }

                    if (choice == 2)
                    {
                        Console.Write("Enter New City: ");
                        rows[0]["City"] = Console.ReadLine()!;
                    }
                    else if (choice == 3)
                    {
                        rows[0].Delete();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice!");
                        return;
                    }
                }

                int result = adapter.Update(ds, "Student");

                Console.WriteLine(result + " Record(s) Updated Successfully!");
            }
        }
    }
}