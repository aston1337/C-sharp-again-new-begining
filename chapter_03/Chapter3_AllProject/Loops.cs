using System;

namespace Chapter_3 {
    public class Loops {
        public static void iterationsAndDecisions() {
            forLoop();
            forEachLoop();
        }

        public static void forLoop() {
            Console.WriteLine("For loop--------------------");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Line number {i}");
            }
        }
        
        public static void forEachLoop() {
            Console.WriteLine("ForEach loop--------------------");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Line number {i}");
            }
        }
    }
}