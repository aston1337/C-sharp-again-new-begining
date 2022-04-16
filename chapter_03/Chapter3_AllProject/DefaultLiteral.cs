using System;

namespace Chapter_3 {
    public class DefaultLiteral {
        public static void defaultDeclarations() {
            Console.WriteLine("Default declarations------------------");
            int myInt = default;        // 0
            float myFloat = default;    // 0
            double MyDouble = default;  // 0
            string myString = default;  // ""
            char myChar = default;      // ""

            bool b = new bool();        // false
            int j = new int();          // 0
            double d = new double();    // 0
            DateTime dt = new DateTime();//1/1/0001 12:00:00 AM
            Console.WriteLine($"{myInt} | {myFloat} | {myString} | {MyDouble} | {myChar} | {dt}");
        }
    }
}