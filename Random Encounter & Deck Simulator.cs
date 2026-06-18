using System;
using System.Collections.Generic;

namespace RandomEncounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // สร้างสำรับการ์ดหรือรายชื่อมอนสเตอร์
            List<string> deck = new List<string> { "Slime", "Goblin", "Orc", "Shadow Knight", "Demon Lord" };
            Random rng = new Random();

            Console.WriteLine("⚔️ Welcome to the Random Encounter Generator ⚔️");
            Console.WriteLine("Press 'Enter' to draw an enemy or type 'exit' to quit.\n");

            while (deck.Count > 0)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;

                // สุ่ม Index
                int index = rng.Next(deck.Count);
                Console.WriteLine($"[!] Encountered: {deck[index]}! (Remaining: {deck.Count - 1})");
                
                // เอาตัวที่สุ่มได้ออกไปจาก List
                deck.RemoveAt(index);
            }

            Console.WriteLine("\nAll entities have been drawn or you exited. Thanks for playing!");
        }
    }
}
