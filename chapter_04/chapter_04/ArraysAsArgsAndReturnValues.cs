using System;

namespace chapter_04 {
    public class ArraysAsArgsAndReturnValues {
        public static void arraysAsArgsAndReturnValues() {
            int[] myInts = new[] { 1, 4, 5, 6, 2, 3, 6 };
            printArray(myInts);
        }

        public static void printArray(int[] myInts) {
            for (int i = 0; i < myInts.Length; i++) {
                Console.WriteLine($"Item {i} is {myInts[i]}");
            }
        }

        static string[] getStringArray() {                          // string[] потому что возвращаем массив строк
            string[] theStrings = { "Hello", "Welcome", "Hi" };
            return theStrings;
        }
    }
}