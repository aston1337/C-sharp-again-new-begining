using System;

namespace Chapter_2 {
    class ConsoleApp {
        public static void Main(string[] args) {
            Console.Title = "My rocking app";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************");
            Console.WriteLine("**** My Rocking app ****");
            Console.WriteLine("************************");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadLine();
        }
    }
}