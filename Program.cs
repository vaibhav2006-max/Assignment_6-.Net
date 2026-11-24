using System;
using StudentConnection;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("===== LAB ASSIGNMENT 6 =====");
            Console.WriteLine("1. Question 1 - Display");
            Console.WriteLine("2. Question 2 - Insert");
            Console.WriteLine("3. Question 3 - Update");
            Console.WriteLine("4. Question 4 - Delete");
            Console.WriteLine("5. Question 5 - Disconnected Display");
            Console.WriteLine("6. Question 6 - Disconnected Insert");
            Console.WriteLine("7. Question 7 - Disconnected Update");
            Console.WriteLine("8. Question 8 - Disconnected Delete");
            Console.WriteLine("9. Question 9 - Command Builder");
            Console.WriteLine("10. Question 10 - Complete CRUD");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter Question Number: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (choice)
            {
                case 1:
                    Question1_Display.Run();
                    break;

                case 2:
                    Question2_Insert.Run();
                    break;

                case 3:
                    Question3_Update.Run();
                    break;

                case 4:
                    Question4_Delete.Run();
                    break;

                case 5:
                    Question5_DisconnectedDisplay.Run();
                    break;

                case 6:
                    Question6_Insert.Run();
                    break;

                case 7:
                    Question7_Update.Run();
                    break;

                case 8:
                    Question8_Delete.Run();
                    break;

                case 9:
                    Question9_CommandBuilder.Run();
                    break;

                case 10:
                    Question10_CompleteCRUD.Run();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            Console.WriteLine("\nPress any key to return to main menu...");
            Console.ReadKey();
        }
    }
}