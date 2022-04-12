using System;

namespace Chapter_1 {
    class Calculator {
        public static void Main(string[] args) {
            Calc num = new Calc();
            int ans = num.add(12, 23);
            Console.WriteLine($"The result is {ans}");
            
        }
    }

    class Calc {
        public int add(int x, int y) {
            return x + y;
        }
    }
}