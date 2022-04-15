using System;

namespace Chapter_3 {
    public class ConsoleClass {
        public static void getUserData() {
            Console.WriteLine("******Basic Console I/O");
            Console.Write("Enter your name:");
            string userName = Console.ReadLine();
            Console.Write("Enter your age:");
            int userAge = Int32.Parse(Console.ReadLine());

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Hello {userName}! You are {userAge} years old!");
            Console.ForegroundColor = prevColor;
        }
    }
}