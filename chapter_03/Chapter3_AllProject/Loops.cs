using System;

namespace Chapter_3 {
    public class Loops {
        public static void iterationsAndDecisions() {
            forLoop();
            forEachLoop();
            whileDoWhile();
        }

        public static void forLoop() {
            Console.WriteLine("For loop--------------------");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Line number {i}");
            }
        }
        
        public static void forEachLoop() {
            Console.WriteLine("ForEach loop--------------------");
            int[] arr = { 10, 2, 3, 4, 34, 65, 2, 3, 5, };
            foreach (int i in arr) {
                Console.Write(i + ", ");
            }
        }
        
        public static void whileDoWhile() {
            Console.WriteLine("WhileAndDoWhile loops --------------------");
            string userDone = "";
            while (userDone.ToLower() != "yes") {
                Console.WriteLine("In while loop");
                Console.WriteLine("Are you done? [yes]/[no]");
                userDone = Console.ReadLine();
            }

            do {
                Console.WriteLine("In Do While loop");
                string userDone2 = "";
                Console.WriteLine("Are you done? [yes]/[no]");
                userDone2 = Console.ReadLine();
            } while (userDone.ToLower() != "yes");
        }
    }
}