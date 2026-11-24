using System;

namespace StudentConnection
{
    public class Question10_CompleteCRUD
    {
        public static void Run()
        {
            Console.WriteLine("\nChoose Architecture:");
            Console.WriteLine("1. Connected Architecture");
            Console.WriteLine("2. Disconnected Architecture");

            Console.Write("Enter Choice: ");
            int architecture =
                Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose Operation:");
            Console.WriteLine("1. Display");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");

            Console.Write("Enter Choice: ");
            int operation =
                Convert.ToInt32(Console.ReadLine());

            if (architecture == 1)
            {
                switch (operation)
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

                    default:
                        Console.WriteLine("Invalid Operation!");
                        break;
                }
            }
            else if (architecture == 2)
            {
                switch (operation)
                {
                    case 1:
                        Question5_DisconnectedDisplay.Run();
                        break;

                    case 2:
                        Question6_Insert.Run();
                        break;

                    case 3:
                        Question7_Update.Run();
                        break;

                    case 4:
                        Question8_Delete.Run();
                        break;

                    default:
                        Console.WriteLine("Invalid Operation!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Architecture!");
            }
        }
    }
}