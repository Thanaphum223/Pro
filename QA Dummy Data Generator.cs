using System;

namespace DummyDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- QA Dummy User Generator ---");
            Console.Write("How many dummy users do you need for testing? : ");

            // เช็คว่ากรอกข้อมูลเป็นตัวเลขหรือไม่
            if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
            {
                Console.WriteLine("\n[ Generating Test Data... ]\n");
                Random rnd = new Random();

                for (int i = 1; i <= count; i++)
                {
                    // สร้าง ID 5 หลักแบบสุ่ม
                    string dummyId = rnd.Next(10000, 99999).ToString();
                    string username = $"TestUser_{dummyId}";
                    string email = $"{username.ToLower()}@testdomain.local";

                    Console.WriteLine($"{i}. Username: {username} | Email: {email}");
                }
                Console.WriteLine("\n[ Generation Complete ]");
            }
            else
            {
                Console.WriteLine("Invalid input. Please run the program again and enter a valid positive number.");
            }
        }
    }
}
